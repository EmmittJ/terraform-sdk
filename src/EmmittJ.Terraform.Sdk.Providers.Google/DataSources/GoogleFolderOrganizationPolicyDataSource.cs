using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_folder_organization_policy.
/// </summary>
public class GoogleFolderOrganizationPolicyDataSource : TerraformDataSource
{
    public GoogleFolderOrganizationPolicyDataSource(string name) : base("google_folder_organization_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("boolean_policy");
        this.DeclareOutput("etag");
        this.DeclareOutput("list_policy");
        this.DeclareOutput("restore_policy");
        this.DeclareOutput("update_time");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The name of the Constraint the Policy is configuring, for example, serviceuser.services.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Constraint is required")]
    public required TerraformProperty<string> Constraint
    {
        get => GetProperty<TerraformProperty<string>>("constraint");
        set => this.WithProperty("constraint", value);
    }

    /// <summary>
    /// The resource name of the folder to set the policy for. Its format is folders/{folder_id}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    public required TerraformProperty<string> Folder
    {
        get => GetProperty<TerraformProperty<string>>("folder");
        set => this.WithProperty("folder", value);
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
    /// A boolean policy is a constraint that is either enforced or not.
    /// </summary>
    public TerraformExpression BooleanPolicy => this["boolean_policy"];

    /// <summary>
    /// The etag of the organization policy. etag is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy from overwriting each other.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// A policy that can define specific values that are allowed or denied for the given constraint. It can also be used to allow or deny all values. 
    /// </summary>
    public TerraformExpression ListPolicy => this["list_policy"];

    /// <summary>
    /// A restore policy is a constraint to restore the default policy.
    /// </summary>
    public TerraformExpression RestorePolicy => this["restore_policy"];

    /// <summary>
    /// The timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, accurate to nanoseconds, representing when the variable was last updated. Example: &amp;quot;2016-10-09T12:33:37.578138407Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// Version of the Policy. Default version is 0.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
