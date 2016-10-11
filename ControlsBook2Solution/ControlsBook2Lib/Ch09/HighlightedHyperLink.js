// Register the namespace for the control.
Type.registerNamespace('ControlsBook2Lib.Ch09');

// Define the control properties.
ControlsBook2Lib.Ch09.HighlightedHyperlink = function(element) 
{ 
    ControlsBook2Lib.Ch09.HighlightedHyperlink.initializeBase(this, [element]);

    this._highlightCssClass = null;
    this._nohighlightCssClass = null;
}

// Create the prototype for the control
ControlsBook2Lib.Ch09.HighlightedHyperlink.prototype = 
{
    initialize : function() 
    {
        ControlsBook2Lib.Ch09.HighlightedHyperlink.callBaseMethod(this, 'initialize');

        this._onMouseOver = Function.createDelegate(this, this._onMouseOver);
        this._onMouseOut = Function.createDelegate(this, this._onMouseOut);

        $addHandlers(this.get_element(), 
                     { 'mouseover' : this._onMouseOver,
                       'mouseout' : this._onMouseOut },
                     this);
        this.get_element().className = this._nohighlightCssClass;        
    },

    dispose : function() 
    {
        $clearHandlers(this.get_element());

        ControlsBook2Lib.Ch09.HighlightedHyperlink.callBaseMethod(this, 'dispose');
    },

    // Event delegates
    _onMouseOver : function(e) 
    {
        if (this.get_element() && !this.get_element().disabled) 
        {
            this.get_element().className = this._highlightCssClass;          
        }       
    },

    _onMouseOut : function(e) 
    {
        if (this.get_element() && !this.get_element().disabled) 
        {
            this.get_element().className = this._nohighlightCssClass;          
        }
    },
    
    // Control properties
    get_highlightCssClass : function() 
    {
        return this._highlightCssClass;
    },

    set_highlightCssClass : function(value) 
    {
        if (this._highlightCssClass !== value) 
        {
            this._highlightCssClass = value;
            this.raisePropertyChanged('highlightCssClass');
        }
    },

    get_nohighlightCssClass : function() 
    {
        return this._nohighlightCssClass;
    },

    set_nohighlightCssClass : function(value) 
    {
        if (this._nohighlightCssClass !== value) 
        {
            this._nohighlightCssClass = value;
            this.raisePropertyChanged('nohighlightCssClass');
        }
    }
}

// Optional descriptor for JSON serialization.
ControlsBook2Lib.Ch09.HighlightedHyperlink.descriptor = 
{
    properties: [   {name: 'highlightCssClass', type: String},
                    {name: 'nohighlightCssClass', type: String} ]
}

// Register the class as a type that inherits from Sys.UI.Control.
ControlsBook2Lib.Ch09.HighlightedHyperlink.registerClass('ControlsBook2Lib.Ch09.HighlightedHyperlink', Sys.UI.Control);

if (typeof(Sys) !== 'undefined') Sys.Application.notifyScriptLoaded();