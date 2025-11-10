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
        SetOutput("arn");
        SetOutput("id");
        SetOutput("tags_all");
        SetOutput("access_association_source");
        SetOutput("access_association_source_type");
        SetOutput("domain_name_arn");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The access_association_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessAssociationSource is required")]
    public required TerraformProperty<string> AccessAssociationSource
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_association_source");
        set => SetProperty("access_association_source", value);
    }

    /// <summary>
    /// The access_association_source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessAssociationSourceType is required")]
    public required TerraformProperty<string> AccessAssociationSourceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_association_source_type");
        set => SetProperty("access_association_source_type", value);
    }

    /// <summary>
    /// The domain_name_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainNameArn is required")]
    public required TerraformProperty<string> DomainNameArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_name_arn");
        set => SetProperty("domain_name_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
