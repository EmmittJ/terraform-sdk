using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_organizations_features resource.
/// </summary>
public class AwsIamOrganizationsFeatures : TerraformResource
{
    public AwsIamOrganizationsFeatures(string name) : base("aws_iam_organizations_features", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("id");
    }

    /// <summary>
    /// The enabled_features attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnabledFeatures is required")]
    public HashSet<TerraformProperty<string>>? EnabledFeatures
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("enabled_features");
        set => this.WithProperty("enabled_features", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
