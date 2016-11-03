#Getting started

## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

1. Open the solution (SuggestGrid.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](http://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=SuggestGrid-CSharp&workspaceName=SuggestGrid&projectName=SuggestGrid.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the SuggestGrid library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](http://apidocs.io/illustration/cs?step=addProject&workspaceFolder=SuggestGrid-CSharp&workspaceName=SuggestGrid&projectName=SuggestGrid.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](http://apidocs.io/illustration/cs?step=createProject&workspaceFolder=SuggestGrid-CSharp&workspaceName=SuggestGrid&projectName=SuggestGrid.PCL)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](http://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=SuggestGrid-CSharp&workspaceName=SuggestGrid&projectName=SuggestGrid.PCL)

### 3. Add reference of the library project

In order to use the SuggestGrid library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](http://apidocs.io/illustration/cs?step=addReference&workspaceFolder=SuggestGrid-CSharp&workspaceName=SuggestGrid&projectName=SuggestGrid.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` SuggestGrid.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```SuggestGrid.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=createReference&workspaceFolder=SuggestGrid-CSharp&workspaceName=SuggestGrid&projectName=SuggestGrid.PCL)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=addCode&workspaceFolder=SuggestGrid-CSharp&workspaceName=SuggestGrid&projectName=SuggestGrid.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication and 
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| basicAuthUserName | The username to use with basic authentication |
| basicAuthPassword | The password to use with basic authentication |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string basicAuthUserName = "basicAuthUserName"; // The username to use with basic authentication
string basicAuthPassword = "basicAuthPassword"; // The password to use with basic authentication

SuggestGridClient client = new SuggestGridClient(basicAuthUserName, basicAuthPassword);
```

## Class Reference

### <a name="list_of_controllers"></a>List of Controllers

* [TypeController](#type_controller)
* [ActionController](#action_controller)
* [MetadataController](#metadata_controller)
* [RecommendationController](#recommendation_controller)
* [SimilarityController](#similarity_controller)

### <a name="type_controller"></a>![Class: ](http://apidocs.io/img/class.png "SuggestGrid.Controllers.TypeController") TypeController

#### Get singleton instance

The singleton instance of the ``` TypeController ``` class can be accessed from the API Client.

```csharp
ITypeController type = client.Type;
```

#### <a name="get_all_types"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.TypeController.GetAllTypes") GetAllTypes

> *Tags:*  ``` Skips Authentication ``` 

> Get All Types


```csharp
Task<GetTypesResponse> GetAllTypes()
```

#### Example Usage

```csharp

GetTypesResponse result = await type.GetAllTypes();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


#### <a name="delete_all_types"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.TypeController.DeleteAllTypes") DeleteAllTypes

> *Tags:*  ``` Skips Authentication ``` 

> Delete All Types


```csharp
Task<GetTypesResponse> DeleteAllTypes()
```

#### Example Usage

```csharp

GetTypesResponse result = await type.DeleteAllTypes();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


#### <a name="get_type"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.TypeController.GetType") GetType

> *Tags:*  ``` Skips Authentication ``` 

> Get Properties of a Type


```csharp
Task<GetTypeResponse> GetType(string type)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| type |  ``` Required ```  | The name of the type to get properties. |


#### Example Usage

```csharp
string type = "type";

GetTypeResponse result = await type.GetType(type);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


#### <a name="create_type"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.TypeController.CreateType") CreateType

> *Tags:*  ``` Skips Authentication ``` 

> Create a New Type


```csharp
Task<MessageResponse> CreateType(string type, TypeRequestBody settings = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| type |  ``` Required ```  | The name of the type to be created. |
| settings |  ``` Optional ```  | Optional settings for the rating parameter. |


#### Example Usage

```csharp
string type = "type";
var settings = new TypeRequestBody();

MessageResponse result = await type.CreateType(type, settings);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 402 | Type limit reached. |
| 409 | Type already exists. |
| 422 | Rating type is not `implicit` or `explicit`. |
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


#### <a name="delete_type"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.TypeController.DeleteType") DeleteType

> *Tags:*  ``` Skips Authentication ``` 

> Delete a Type


```csharp
Task<MessageResponse> DeleteType(string type)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| type |  ``` Required ```  | The name of the type to be deleted. |


#### Example Usage

```csharp
string type = "type";

MessageResponse result = await type.DeleteType(type);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Type does not exists. |
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


[Back to List of Controllers](#list_of_controllers)

### <a name="action_controller"></a>![Class: ](http://apidocs.io/img/class.png "SuggestGrid.Controllers.ActionController") ActionController

#### Get singleton instance

The singleton instance of the ``` ActionController ``` class can be accessed from the API Client.

```csharp
IActionController action = client.Action;
```

#### <a name="get_actions"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.ActionController.GetActions") GetActions

> *Tags:*  ``` Skips Authentication ``` 

> Get Actions


```csharp
Task<CountResponse> GetActions(
        string type = null,
        string userId = null,
        string itemId = null,
        string olderThan = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| type |  ``` Optional ```  | The type of the actions. |
| userId |  ``` Optional ```  | The user id of the actions. |
| itemId |  ``` Optional ```  | The item id of the actions. |
| olderThan |  ``` Optional ```  | Delete all actions of a type older than the given timestamp or time.
Valid times are 1s, 1m, 1h, 1d, 1M, 1y, or unix timestamp (like 1443798195). |


#### Example Usage

```csharp
string type = "type";
string userId = "user_id";
string itemId = "item_id";
string olderThan = "older_than";

CountResponse result = await action.GetActions(type, userId, itemId, olderThan);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Required `user_id` or `item_id` parameters are missing from the request body. |
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


#### <a name="post_action"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.ActionController.PostAction") PostAction

> *Tags:*  ``` Skips Authentication ``` 

> Post an Action


```csharp
Task<MessageResponse> PostAction(Action action)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| action |  ``` Required ```  | The action to be posted. |


#### Example Usage

```csharp
var action = new Action();

MessageResponse result = await action.PostAction(action);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Required `user_id` or `item_id` parameters are missing from the request body. |
| 402 | Action limit exceeded. |
| 404 | Type does not exists. |
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


#### <a name="delete_actions"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.ActionController.DeleteActions") DeleteActions

> *Tags:*  ``` Skips Authentication ``` 

> Delete Actions


```csharp
Task<MessageResponse> DeleteActions(
        string type = null,
        string userId = null,
        string itemId = null,
        string olderThan = null)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| type |  ``` Optional ```  | The type of the actions. |
| userId |  ``` Optional ```  | The user id of the actions. |
| itemId |  ``` Optional ```  | The item id of the actions. |
| olderThan |  ``` Optional ```  | Delete all actions of a type older than the given timestamp or time.
Valid times are 1s, 1m, 1h, 1d, 1M, 1y, or unix timestamp (like 1443798195). |


#### Example Usage

```csharp
string type = "type";
string userId = "user_id";
string itemId = "item_id";
string olderThan = "older_than";

MessageResponse result = await action.DeleteActions(type, userId, itemId, olderThan);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Required `user_id` or `item_id` parameters are missing from the request body. |
| 404 | Type does not exists. |
| 422 | No query parameter (`user_id`, `item_id`, or `older_than`) is given.  In order to delete all actionsdelete the type. |
| 429 | Too many requests. |
| 505 | Request timed out. |
| 500 | Unexpected internal error. |


#### <a name="post_bulk_actions"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.ActionController.PostBulkActions") PostBulkActions

> *Tags:*  ``` Skips Authentication ``` 

> Post Bulk Actions


```csharp
Task<MessageResponse> PostBulkActions(string actions)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| actions |  ``` Required ```  | A number of action objects separated with newlines.
Note that this is not a valid JSON data structure.
The body size is limited to 10 thousand lines. |


#### Example Usage

```csharp
string actions = "actions";

MessageResponse result = await action.PostBulkActions(actions);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 209 | Some metadata is not uploaded successfully. |
| 400 | Body is missing. |
| 402 | Action limit exceeded. |
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


[Back to List of Controllers](#list_of_controllers)

### <a name="metadata_controller"></a>![Class: ](http://apidocs.io/img/class.png "SuggestGrid.Controllers.MetadataController") MetadataController

#### Get singleton instance

The singleton instance of the ``` MetadataController ``` class can be accessed from the API Client.

```csharp
IMetadataController metadata = client.Metadata;
```

#### <a name="delete_user"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.MetadataController.DeleteUser") DeleteUser

> *Tags:*  ``` Skips Authentication ``` 

> Delete a User


```csharp
Task<MessageResponse> DeleteUser(string userId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| userId |  ``` Required ```  | The user id to delete its metadata. |


#### Example Usage

```csharp
string userId = "user_id";

MessageResponse result = await metadata.DeleteUser(userId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


#### <a name="get_users"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.MetadataController.GetUsers") GetUsers

> *Tags:*  ``` Skips Authentication ``` 

> Get Users


```csharp
Task<MetadataInformationResponse> GetUsers()
```

#### Example Usage

```csharp

MetadataInformationResponse result = await metadata.GetUsers();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


#### <a name="post_user"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.MetadataController.PostUser") PostUser

> *Tags:*  ``` Skips Authentication ``` 

> Post a User


```csharp
Task<MessageResponse> PostUser(Metadata user)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| user |  ``` Required ```  | The metadata to be saved. Metadata format has its restrictions. |


#### Example Usage

```csharp
var user = new Metadata();

MessageResponse result = await metadata.PostUser(user);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Metadata is invalid. |
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


#### <a name="delete_all_users"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.MetadataController.DeleteAllUsers") DeleteAllUsers

> *Tags:*  ``` Skips Authentication ``` 

> Delete All Users


```csharp
Task<MessageResponse> DeleteAllUsers()
```

#### Example Usage

```csharp

MessageResponse result = await metadata.DeleteAllUsers();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


#### <a name="delete_item"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.MetadataController.DeleteItem") DeleteItem

> *Tags:*  ``` Skips Authentication ``` 

> Delete an Item


```csharp
Task<MessageResponse> DeleteItem(string itemId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| itemId |  ``` Required ```  | The item id to delete its metadata. |


#### Example Usage

```csharp
string itemId = "item_id";

MessageResponse result = await metadata.DeleteItem(itemId);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


#### <a name="get_items"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.MetadataController.GetItems") GetItems

> *Tags:*  ``` Skips Authentication ``` 

> Get Items


```csharp
Task<MetadataInformationResponse> GetItems()
```

#### Example Usage

```csharp

MetadataInformationResponse result = await metadata.GetItems();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


#### <a name="post_item"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.MetadataController.PostItem") PostItem

> *Tags:*  ``` Skips Authentication ``` 

> Post an Item


```csharp
Task<MessageResponse> PostItem(Metadata item)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| item |  ``` Required ```  | The metadata to be saved. Metadata format has its restrictions. |


#### Example Usage

```csharp
var item = new Metadata();

MessageResponse result = await metadata.PostItem(item);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Metadata is invalid. |
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


#### <a name="delete_all_items"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.MetadataController.DeleteAllItems") DeleteAllItems

> *Tags:*  ``` Skips Authentication ``` 

> Delete All Items


```csharp
Task<MessageResponse> DeleteAllItems()
```

#### Example Usage

```csharp

MessageResponse result = await metadata.DeleteAllItems();

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


#### <a name="post_bulk_users"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.MetadataController.PostBulkUsers") PostBulkUsers

> *Tags:*  ``` Skips Authentication ``` 

> Post Bulk Users


```csharp
Task<MessageResponse> PostBulkUsers(string users)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| users |  ``` Required ```  | A number of user metadata objects separated with newlines.
Each user metadata object must have its id field.
Note that this is not a valid JSON data structure.
The body size is limited to 10 thousand lines. |


#### Example Usage

```csharp
string users = "users";

MessageResponse result = await metadata.PostBulkUsers(users);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 209 | Some metadata is not uploaded successfully. |
| 400 | Body is missing. |
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


#### <a name="post_bulk_items"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.MetadataController.PostBulkItems") PostBulkItems

> *Tags:*  ``` Skips Authentication ``` 

> Post Bulk Items


```csharp
Task<MessageResponse> PostBulkItems(string items)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| items |  ``` Required ```  | A number of item metadata objects separated with newlines.
Each item metadata object must have its id field.
Note that this is not a valid JSON data structure.
The body size is limited to 10 thousand lines. |


#### Example Usage

```csharp
string items = "items";

MessageResponse result = await metadata.PostBulkItems(items);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 209 | Some metadata is not uploaded successfully. |
| 400 | Body is missing. |
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


[Back to List of Controllers](#list_of_controllers)

### <a name="recommendation_controller"></a>![Class: ](http://apidocs.io/img/class.png "SuggestGrid.Controllers.RecommendationController") RecommendationController

#### Get singleton instance

The singleton instance of the ``` RecommendationController ``` class can be accessed from the API Client.

```csharp
IRecommendationController recommendation = client.Recommendation;
```

#### <a name="get_recommended_users"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.RecommendationController.GetRecommendedUsers") GetRecommendedUsers

> *Tags:*  ``` Skips Authentication ``` 

> Get Recommended Users


```csharp
Task<UsersResponse> GetRecommendedUsers(GetRecommendedUsersBody query)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| query |  ``` Required ```  | The query for recommended users. |


#### Example Usage

```csharp
var query = new GetRecommendedUsersBody();

UsersResponse result = await recommendation.GetRecommendedUsers(query);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Request body is invalid. |
| 422 | Required parameters are missing. |
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


#### <a name="get_recommended_items"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.RecommendationController.GetRecommendedItems") GetRecommendedItems

> *Tags:*  ``` Skips Authentication ``` 

> Get Recommended Items


```csharp
Task<ItemsResponse> GetRecommendedItems(GetRecommendedItemsBody query)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| query |  ``` Required ```  | The query for recommended items. |


#### Example Usage

```csharp
var query = new GetRecommendedItemsBody();

ItemsResponse result = await recommendation.GetRecommendedItems(query);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Request body is invalid. |
| 422 | Required parameters are missing. |
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


[Back to List of Controllers](#list_of_controllers)

### <a name="similarity_controller"></a>![Class: ](http://apidocs.io/img/class.png "SuggestGrid.Controllers.SimilarityController") SimilarityController

#### Get singleton instance

The singleton instance of the ``` SimilarityController ``` class can be accessed from the API Client.

```csharp
ISimilarityController similarity = client.Similarity;
```

#### <a name="get_similar_users"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.SimilarityController.GetSimilarUsers") GetSimilarUsers

> *Tags:*  ``` Skips Authentication ``` 

> Get Similar Users


```csharp
Task<UsersResponse> GetSimilarUsers(GetSimilarUsersBody query)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| query |  ``` Required ```  | The query for similar users. |


#### Example Usage

```csharp
var query = new GetSimilarUsersBody();

UsersResponse result = await similarity.GetSimilarUsers(query);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Request body is invalid. |
| 422 | Required parameters are missing. |
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


#### <a name="get_similar_items"></a>![Method: ](http://apidocs.io/img/method.png "SuggestGrid.Controllers.SimilarityController.GetSimilarItems") GetSimilarItems

> *Tags:*  ``` Skips Authentication ``` 

> Get Similar Items


```csharp
Task<ItemsResponse> GetSimilarItems(GetSimilarItemsBody query)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| query |  ``` Required ```  | The query for similar items. |


#### Example Usage

```csharp
var query = new GetSimilarItemsBody();

ItemsResponse result = await similarity.GetSimilarItems(query);

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 400 | Request body is invalid. |
| 422 | Required parameters are missing. |
| 429 | Too many requests. |
| 500 | Unexpected internal error. |


[Back to List of Controllers](#list_of_controllers)



