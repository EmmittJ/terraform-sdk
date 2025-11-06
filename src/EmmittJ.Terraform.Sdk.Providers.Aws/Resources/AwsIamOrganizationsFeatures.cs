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
    public HashSet<string>? EnabledFeatures
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("enabled_features")?.Value;
        set => this.WithProperty("enabled_features", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
