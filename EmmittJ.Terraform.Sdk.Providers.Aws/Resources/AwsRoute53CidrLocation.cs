using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_cidr_location resource.
/// </summary>
public class AwsRoute53CidrLocation : TerraformResource
{
    public AwsRoute53CidrLocation(string name) : base("aws_route53_cidr_location", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The cidr_blocks attribute.
    /// </summary>
    public HashSet<string>? CidrBlocks
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("cidr_blocks")?.Value;
        set => this.WithProperty("cidr_blocks", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The cidr_collection_id attribute.
    /// </summary>
    public string? CidrCollectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cidr_collection_id")?.Value;
        set => this.WithProperty("cidr_collection_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
