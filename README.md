# Introduction to .NET Forms Lecture

## Initial setup
- Create a new MVC app called `Lecture`
- Add View compilation to `startup.cs`
  - `dotnet add package Microsoft.AspNetCore.MVC.Razor.RuntimeCompilation`
  ```services.AddControllersWithViews().AddRazorRuntimeCompilation();```
### Database Setup
- Add the required Entity Framework packages

- Create a model called `Invite` with the following properties:
  - `id` - int
  - `Name` - string
  - `IsAttending` - bool
  - `NumberOfHousePartiesAttended` - int
  - `Age` - int

- Create a `DbContext` called `InviteContext` in new subdirectory called `Dao`
- Create a `DbSet` called `Invites`
- Create a Sqlite configuration string in `appsettings.json` using
  ```
    "ConnectionStrings" : {
    "DefaultDBConnection" : "DataSource=invites.db"
  }
  ```
- Update the `startup.cs` file to include reference to created database context and connection string in the `ConfigurationServices` method
  
- Run the entity framework commands to:
  - Create Migrations
  - Apply migrations to the database
  - Use the Sqlite Plug-in to ensure the database was created

### Controllers and Views
- Create a new controller called `HousePartyController`
- Create the following Actions/Endpoints and sanity check in PostMan
  - `ViewInvite` that accepts an invite `id` and returns a specific invite or an error message
  - `ListInvites` that returns all invites
  - `AddInvite` that adds a new invite (HTTP POST)
- Add the database code to perform the required action 

- Create a corresponding View for each action accepting a model reference and then sanity check (NOTE: `AddInvite` needs no model)
  - Modify the `ViewInvite` view to display the invite details or an error if no invite matched
  - Modify the `ListInvites` view to display a table of invite details of each invite or the message `No invites found` 
  
### Add Invite Form
- Create a basic form in `AddInvite`
  - `@Html.BeginForm`
  - `@Html.LabelFor`
  - `@Html.TextBoxFor`
  - `@Html.CheckBoxFor`
  - submit button
- Formatting
  - Use `new{}` to add attributes like `form-control`
    - Change checkbox for display (https://getbootstrap.com/docs/4.1/components/forms/)
    - Improve label names by using Model annotations
- Saving data with a bound model
  - Create second action `CreateInvite` to accept a bound `Invitee` model
  - Save changes
- Using redirect

## Extra: Handling Model Errors
- Create a view model under `ViewModels` called `AddInviteForm` that includes a `List<string> Errors` and an `Invite` model reference
- Modify the `CreateInvite` action so that if there are errors with the model, that it will redirect back to `AddInvite` and pass in a view model instance
- Modify your `AddInvite` view to display any errors with submission along with form (https://v4-alpha.getbootstrap.com/components/alerts/#examples)

### Error List Method
```
        public static List<string> GetErrorListFromModelState
                                              (ModelStateDictionary modelState)
        {
            var query = from state in modelState.Values
                        from error in state.Errors
                        select error.ErrorMessage;

            var errorList = query.ToList();
            return errorList;
        }
```        

