// Register the namespace for the control.
Type.registerNamespace('ControlsBook2Lib.Ch09');

// Define the behavior properties.
ControlsBook2Lib.Ch09.TextCaseBehavior = function(element) 
{ 
    ControlsBook2Lib.Ch09.TextCaseBehavior.initializeBase(this, [element]);
    
    this._caseStyle = null;
}

// Create the prototype for the behavior
ControlsBook2Lib.Ch09.TextCaseBehavior.prototype = 
{
    initialize : function() 
    {
        ControlsBook2Lib.Ch09.TextCaseBehavior.callBaseMethod(this, 'initialize');

        $addHandlers(this.get_element(), 
                     { 'keyup' : this._onKeyUp},//Note onkeyups => 'keyup' when adding handlers
                     this);                     
    },

    dispose : function() 
    {
        $clearHandlers(this.get_element()); 
        ControlsBook2Lib.Ch09.TextCaseBehavior.callBaseMethod(this, 'dispose');
    },

    _onKeyUp: function(e)
    {
        if (this.get_element() && !this.get_element().disabled)
        {
            switch(this._caseStyle)
            {
            case 'LowerCase':
              this.get_element().value=this.get_element().value.toLowerCase();  
              break    
            case 'UpperCase':
              this.get_element().value=this.get_element().value.toUpperCase();  
              break
            case 'TitleCase':
              this.get_element().value=this.get_element().value.toLowerCase(); 
              this.get_element().value=this.get_element().value.toTitleCase();    
              break
            }             
        }
    },
    
    // Behavior property
     get_caseStyle : function() 
     {
        return this._caseStyle;
    },

    set_caseStyle : function(value) 
    {
        if (this._caseStyle !== value) 
        {
            this._caseStyle = value;
            this.raisePropertyChanged('caseStyle');
        }
    }
}

// Optional descriptor for JSON serialization.
ControlsBook2Lib.Ch09.TextCaseBehavior.descriptor = 
{
    properties: [ {name: 'caseStyle', type: String} ]
}

// Register the class as a type that inherits from Sys.UI.Control.
ControlsBook2Lib.Ch09.TextCaseBehavior.registerClass('ControlsBook2Lib.Ch09.TextCaseBehavior', Sys.UI.Behavior);

//Create toTitleCase() prototype
String.prototype.toTitleCase = function () 
{
	var str = "";
	var str2 = "" ;
	var tokens = this.split(' ');
	for(key in tokens)
	{
	  str2 = tokens[key].substr(0,1).toUpperCase()
	 + tokens[key].substr(1,tokens[key].length);
	 
    //Don't add space if on last token in string
	  if (key != (tokens.length-1))
      str += str2+' ';
     else
      str+=str2;
	}
   return str;
}

if (typeof(Sys) !== 'undefined') Sys.Application.notifyScriptLoaded();