using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadAppRoleAssignmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Manages a azuread_app_role_assignment resource.
/// </summary>
public class AzureadAppRoleAssignment : TerraformResource
{
    public AzureadAppRoleAssignment(string name) : base("azuread_app_role_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("principal_display_name");
        this.DeclareOutput("principal_type");
        this.DeclareOutput("resource_display_name");
    }

    /// <summary>
    /// The ID of the app role to be assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppRoleId is required")]
    public required TerraformProperty<string> AppRoleId
    {
        get => GetProperty<TerraformProperty<string>>("app_role_id");
        set => this.WithProperty("app_role_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The object ID of the user, group or service principal to be assigned this app role
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalObjectId is required")]
    public required TerraformProperty<string> PrincipalObjectId
    {
        get => GetProperty<TerraformProperty<string>>("principal_object_id");
        set => this.WithProperty("principal_object_id", value);
    }

    /// <summary>
    /// The object ID of the service principal representing the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceObjectId is required")]
    public required TerraformProperty<string> ResourceObjectId
    {
        get => GetProperty<TerraformProperty<string>>("resource_object_id");
        set => this.WithProperty("resource_object_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadAppRoleAssignmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadAppRoleAssignmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The display name of the principal to which the app role is assigned
    /// </summary>
    public TerraformExpression PrincipalDisplayName => this["principal_display_name"];

    /// <summary>
    /// The object type of the principal to which the app role is assigned
    /// </summary>
    public TerraformExpression PrincipalType => this["principal_type"];

    /// <summary>
    /// The display name of the application representing the resource
    /// </summary>
    public TerraformExpression ResourceDisplayName => this["resource_display_name"];

}
