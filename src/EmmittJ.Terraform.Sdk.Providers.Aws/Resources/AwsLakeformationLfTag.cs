using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lakeformation_lf_tag resource.
/// </summary>
public class AwsLakeformationLfTag : TerraformResource
{
    public AwsLakeformationLfTag(string name) : base("aws_lakeformation_lf_tag", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public string? CatalogId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("catalog_id")?.Value;
        set => this.WithProperty("catalog_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The key attribute.
    /// </summary>
    public string? Key
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key")?.Value;
        set => this.WithProperty("key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The values attribute.
    /// </summary>
    public HashSet<string>? Values
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("values")?.Value;
        set => this.WithProperty("values", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

}
