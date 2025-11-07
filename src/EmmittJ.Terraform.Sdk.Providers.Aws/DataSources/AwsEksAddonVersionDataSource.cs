using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_eks_addon_version.
/// </summary>
public class AwsEksAddonVersionDataSource : TerraformDataSource
{
    public AwsEksAddonVersionDataSource(string name) : base("aws_eks_addon_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The addon_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AddonName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("addon_name");
        set => this.WithProperty("addon_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KubernetesVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kubernetes_version");
        set => this.WithProperty("kubernetes_version", value);
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? MostRecent
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("most_recent");
        set => this.WithProperty("most_recent", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
