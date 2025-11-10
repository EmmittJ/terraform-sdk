using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_organizations_policies_for_target.
/// </summary>
public class AwsOrganizationsPoliciesForTargetDataSource : TerraformDataSource
{
    public AwsOrganizationsPoliciesForTargetDataSource(string name) : base("aws_organizations_policies_for_target", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("ids");
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformProperty<string> Filter
    {
        get => GetRequiredProperty<TerraformProperty<string>>("filter");
        set => this.WithProperty("filter", value);
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
    /// The target_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetId is required")]
    public required TerraformProperty<string> TargetId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("target_id");
        set => this.WithProperty("target_id", value);
    }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformExpression Ids => this["ids"];

}
