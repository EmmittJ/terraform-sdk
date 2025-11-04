using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

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
    public string? AppRoleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_role_id")?.Value;
        set => this.WithProperty("app_role_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object ID of the user, group or service principal to be assigned this app role
    /// </summary>
    public string? PrincipalObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_object_id")?.Value;
        set => this.WithProperty("principal_object_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The object ID of the service principal representing the resource
    /// </summary>
    public string? ResourceObjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_object_id")?.Value;
        set => this.WithProperty("resource_object_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
