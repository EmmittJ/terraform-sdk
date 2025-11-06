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
    public string? AddonName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("addon_name")?.Value;
        set => this.WithProperty("addon_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The kubernetes_version attribute.
    /// </summary>
    public string? KubernetesVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kubernetes_version")?.Value;
        set => this.WithProperty("kubernetes_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    public bool? MostRecent
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("most_recent")?.Value;
        set => this.WithProperty("most_recent", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
