using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum eSlideDirection {Up=0, Down, Right, Left}
public enum eSlideState		{Closed=0, Closing, Opening, Open}

[System.Serializable]
public class crMenuItem  {
	public string			menuText;
	public Texture			menuImage;
	public string			menuAction;
}

[System.Serializable]
public class crMenu  {

	public string			MenuName;
	private Rect targetPos = new Rect(0,0,150,150);
    private float offset = .15f;
	public crMenuItem[]		menuItems;
	public eSlideDirection	slideInDirection	= eSlideDirection.Right;
	public eSlideDirection	slideOutDirection	= eSlideDirection.Right;
	public float			slideSpeed = 300.0f;

	private eSlideState		slideState 			= eSlideState.Closed;
	private GUISkin			menuSkin;
	private float			alpha = 0;
	private Rect			curPos;
	private GameObject		parent;
	
	public GameObject Parent 
	{
		set {parent = value;}
	}

	public float Alpha 
	{
		set {alpha = value;}
		get {return alpha;}
	}

	public Rect Pos 
	{
		get {return curPos;}
	}

	//set the menu to start at a proper offset to allow for smooth fading
	public void Hide()
	{
        targetPos.x = Screen.width - (Screen.width * offset); //My code to make on right side
        targetPos.y = Screen.height * offset; //My code
        targetPos.height = Screen.width / 5;
        targetPos.width = Screen.width / 5;
        switch (slideInDirection)
		{
            case eSlideDirection.Up:
                curPos = new Rect(targetPos.x,targetPos.y + targetPos.height,targetPos.width,targetPos.height);
                break;
            case eSlideDirection.Down:
                curPos = new Rect(targetPos.x,targetPos.y - targetPos.height,targetPos.width,targetPos.height);
                break;
			case eSlideDirection.Right:
                curPos = new Rect(targetPos.x - targetPos.width,targetPos.y,targetPos.width,targetPos.height);
                break;
			case eSlideDirection.Left:
                curPos = new Rect(targetPos.x + targetPos.width,targetPos.y,targetPos.width,targetPos.height);
                break;
		}
	}

	//make sure the various menus use the same skin as specified
	public void SetSkin(GUISkin skn)
	{
		menuSkin = skn;
	}
	
	//start the process of fading in
	public void Activate()
	{
        if (slideState < eSlideState.Opening)
			slideState = eSlideState.Opening;
	}
	
	//start the process of fading out
	public void Deactivate()
	{
		if (slideState > eSlideState.Closing)	
			slideState = eSlideState.Closing;
	}
	
	void DetermineAlpha()
	{
		float dist = 0;
		float perc = 0;

		//determine wether themenu is sliding in or out to determine which axis to use for alpha testing
		eSlideDirection	slideDirection = (slideState == eSlideState.Opening) ? slideInDirection : slideOutDirection;
		switch (slideDirection)
		{
			case eSlideDirection.Up		:
			case eSlideDirection.Down	:
					dist = targetPos.y - curPos.y;
					break;
					
			case eSlideDirection.Right	: 
			case eSlideDirection.Left	:
					dist = targetPos.x - curPos.x;
					break;
		}
		
		//speed up fading so the menu fades in half the tranvel distance
		if (dist < 0) dist *= -1;
		if (dist != 0)
			dist *= 2;
		
		//test the difference between current pos and target location
		//target location being the position the menu should display at
		//or the position right next to it, offset by exactly the size of the menu
		//return the distance as a percentage and set alpha to that percentage
		switch (slideDirection)
		{
			case eSlideDirection.Up:
			case eSlideDirection.Down:
				perc = 1 - (dist / targetPos.height);
				break;

			case eSlideDirection.Right:
			case eSlideDirection.Left:
				perc = 1 - (dist / targetPos.width);
				break;
		}
		
		if (perc > 1) perc = 1;
		if (perc < 0) perc = 0;
		alpha = perc;
	}
	
	public void Update ()
	{
		switch (slideState)
		{
			
			//if menu is opening: Update position, determine transparency and change state when done
			case eSlideState.Opening: 
				switch (slideInDirection)
				{
                    case eSlideDirection.Up :
						curPos.y -= slideSpeed * Time.deltaTime;
						if (curPos.y <= targetPos.y)
							curPos.y = targetPos.y;
						break;

                    case eSlideDirection.Down :
						curPos.y += slideSpeed * Time.deltaTime;
						if (curPos.y >= targetPos.y)
							curPos.y = targetPos.y;
						break;

					case eSlideDirection.Right :
						curPos.x += slideSpeed * Time.deltaTime;
						if (curPos.x >= targetPos.x)
							curPos.x = targetPos.x;
						break;

					case eSlideDirection.Left :
						curPos.x -= slideSpeed * Time.deltaTime;
						if (curPos.x <= targetPos.x)
							curPos.x = targetPos.x;
						break;
				}

				DetermineAlpha();
				if (alpha == 1)
					slideState = eSlideState.Open;
				break;
				
			
			//if the menu is closing: update the position, determine transparency and change state when done
			case eSlideState.Closing:
				switch (slideOutDirection)
				{
					case eSlideDirection.Up :
						curPos.y -= slideSpeed * Time.deltaTime;
						break;

					case eSlideDirection.Down :
						curPos.y += slideSpeed * Time.deltaTime;
						break;

					case eSlideDirection.Right :
						curPos.x += slideSpeed * Time.deltaTime;
						break;

					case eSlideDirection.Left :
						curPos.x -= slideSpeed * Time.deltaTime;
						break;
				}
				DetermineAlpha();
				if (alpha == 0)
				{
					slideState = eSlideState.Closed;
					Hide();
				}
				break;
		}
	}
	
	public void OnGUI()
	{
		//don't process anything if the menu is invisible
		if (slideState == eSlideState.Closed) return;

 		GUI.skin = menuSkin;

		//get the current alpha value and assign it to the menu
		Color newcol = GUI.color;
		newcol.a = alpha;
		GUI.color = newcol;

		//if the menu has items, show it
		if (menuItems.Length > 0)
		{
			//adjust button size to fit the size allocated for the menu
			//and show the menu items
			float buttonHeight = (targetPos.height / menuItems.Length) ;
			GUI.BeginGroup(curPos);
				for (int x = 0; x < menuItems.Length; x++)
				{
					bool selected = false;
                
					//if the menu item has an image attached to it, use the image for the button
					//otherwise show the text value of the menu item
					if (menuItems[x].menuImage == null)
						selected = GUI.Button(new Rect(0, x * (buttonHeight ), targetPos.width, buttonHeight), menuItems[x].menuText);
					else
						selected = GUI.Button(new Rect(0, x * (buttonHeight ), targetPos.width, buttonHeight), menuItems[x].menuImage);

					if (selected)
						parent.SendMessage("OnClicked", menuItems[x].menuAction);
				}
			GUI.EndGroup();
		}
	}
}

public class crMenuSystem : MonoBehaviour
{
	public GUISkin				menuSkin;						//The skin you want all menus to use
	public	crMenu[]			Menus;							//Configure all your menu pages
	
	private crMenu				activeMenu;						//The menu to receive all input commands
	private crMenu				deactivatingMenu;				//The menu that will fadde out
	private bool				menuIsActive = true;			//Wether the menu system is active or disabled
	private System.Collections.Generic.List<crMenu>	menuPath;	//Traversed menu heirarchy so you can click on 'Back'

	public bool isActive 
	{
		get {return menuIsActive;}
	}
	
	void Start()
	{
		//store the menu navigation path so you can traverse back up the menu tree
		menuPath = new System.Collections.Generic.List<crMenu>();
		
		//prepare the various menu items to work with the functions in this kit
		for (int i = 0; i < Menus.Length; i++)
		{
			Menus[i].Hide();
			Menus[i].SetSkin(menuSkin);
			Menus[i].Parent = gameObject;
		}
	}
	
	bool ShowMenu(string named, bool addToPath)
	{
		if (named != "")
		{
			//see if the menu we want to display exists
			for (int i =0; i < Menus.Length; i++)
			{
				if (Menus[i].MenuName == named)
				{
					//if a menu is already active, make it fade away
					if (activeMenu != null)
					{
						deactivatingMenu = activeMenu;
						activeMenu.Deactivate();
						if (addToPath)
							menuPath.Add(activeMenu);
					}
					//fade in the new menu
					activeMenu = Menus[i];
					activeMenu.Activate();
					return true;
				}
			}
		} else

		// if menu to show is empty, deactivate all menus
		{
			menuPath.Clear();
			if (activeMenu != null)
			{
				deactivatingMenu = activeMenu;
				activeMenu.Deactivate();
				activeMenu = null;
			}
		}
		//if the code reached here then we can safely assume that a new menu was not loaded
		//the only time the return value is checked is to determine wether a menu exists
		//or not. so since it wasn't found, return false
		return false;
	}
	
	//see if there are any menus fading in or out and update their positions
	void Update()
	{
		if (activeMenu != null)
			if (activeMenu.Alpha < 1)
				activeMenu.Update();
			
		if (deactivatingMenu != null)
			if (deactivatingMenu.Alpha > 0)
				deactivatingMenu.Update();
	}
	
	void OnGUI()
	{
		//only allow the menu to be navigated if you are still in the menu system
		//once you enter an external screen from the menu, disable menu navigation
		GUI.skin = menuSkin;
		GUI.enabled = menuIsActive;
		
		//show the currently selected menu
		if (activeMenu != null)
			activeMenu.OnGUI();
			
		//also show the last active menu while it is fading out
		if (deactivatingMenu != null)
			deactivatingMenu.OnGUI();
	}

	//when a menu item is clicked, it sends the action to this function
	//First check if there is a menu with that name and call it if there is
	//or else assume it is a function call and pass that along to the game object...
	public void OnClicked(string param)
	{
		if (!ShowMenu(param, true))
		{
			gameObject.SendMessage(param, SendMessageOptions.DontRequireReceiver);
			ShowMenu("", false);
			ActivateMenu(false);
		}
	}
	
	public void ActivateMenu(bool yesno)
	{
		menuIsActive = yesno;
	}
	
	public void TraverseMenu()
	{
		//if I am in a submenu, no matter how many levels deep, clicking on the menu button
		//acts as a "Back" button and goes to the menu one level up
		if (menuPath.Count > 0)
		{
			crMenu lastMenu = menuPath[menuPath.Count-1];
			menuPath.RemoveAt(menuPath.Count-1);
			ShowMenu(lastMenu.MenuName, false);
		} else
		//if there is no menu currently active, show the first one in the list.
		{
			if (activeMenu != null)
				ShowMenu("", false);
			else
				if (Menus != null)
					if (Menus.Length > 0)
						ShowMenu(Menus[0].MenuName, true);
		}
	}
}