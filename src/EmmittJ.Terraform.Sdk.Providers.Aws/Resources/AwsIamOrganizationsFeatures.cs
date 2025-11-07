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
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The enabled_features attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? EnabledFeatures
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("enabled_features");
        set => this.WithProperty("enabled_features", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
