using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_api_gateway_domain_name_access_association resource.
/// </summary>
public class AwsApiGatewayDomainNameAccessAssociation : TerraformResource
{
    public AwsApiGatewayDomainNameAccessAssociation(string name) : base("aws_api_gateway_domain_name_access_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The access_association_source attribute.
    /// </summary>
    public string? AccessAssociationSource
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_association_source")?.Value;
        set => this.WithProperty("access_association_source", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The access_association_source_type attribute.
    /// </summary>
    public string? AccessAssociationSourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_association_source_type")?.Value;
        set => this.WithProperty("access_association_source_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_name_arn attribute.
    /// </summary>
    public string? DomainNameArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name_arn")?.Value;
        set => this.WithProperty("domain_name_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
