# JSON-CircularRef

Examples for how to enable circular reference serialisation in Dot Net Web API and basic Jquery.

This is a work in progress and I hope to be adding more examples and documentation in the future.

# Web API Example

The Web API example utilises a code first approach for simplicity sake but the serialisation works in exactly the same manner if you are doing Database First.

NB: Please note I built this example using VS 2013 Community Edition so please check the web config connection string and make sure it is pointing to the correct localdb instance as I had trouble with it.

# Dojo Framework Usage

I am curretly using the dojo frameworks dojox.json.ref extentions which have a nice and robust looking JSON parser.

The reason we need a parser is because Newtonsoft JSON utilises JSON referencing via ID values. I.E. Each object is assigned an ID for tracking purposes.

The dojox.json.ref extentions also support JPath which is another method for generating or passing JSON objects.
