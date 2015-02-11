# JSON-CircularRef

Examples for how to enable circular reference serialisation in Dot Net Web API and basic Jquery.

This is a work in progress and I hope to be adding more examples and documentation in the future.

# Web API Example

The Web API example utilises a code first approach for simplicity sake but the serialisation works in exactly the same manner if you are doing Database First.

NB: Please note I built this example using VS 2013 Community Edition so please check the web config connection string and make sure it is pointing to the correct localdb instance as I had trouble with it.

Step One

Web API's default javascript serialiser is NewtonSoft.JSON. It supports serialisation of circular references.

Under the App_Start folder add the following line to the WebAPIConfig register method. 

config.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All;

Step Two

Disable proxy generation on your DbContext Class by setting the following property to true.

Configuration.ProxyCreationEnabled = false

Step Three

Use the dojox.json.ref extention to parse the JSON object sent down through Web API as below.

dojox.json.ref.resolveJson(returnedJSONObject)


# Dojo Framework Usage

I am curretly using the dojo frameworks dojox.json.ref extentions which have a nice and robust looking JSON parser.

The reason we need a parser is because Newtonsoft JSON utilises JSON referencing via ID values. I.E. Each object is assigned an ID for tracking purposes.

The dojox.json.ref extentions also support JPath which is another standard for generating references to JSON objects. I think this is great because if you are utilising another serialiser then you may be able to parse the JSON it produces.
