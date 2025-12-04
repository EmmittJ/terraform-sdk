using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_api_gateway_domain_name_access_association Terraform resource.
/// Manages a aws_api_gateway_domain_name_access_association resource.
/// </summary>
public partial class AwsApiGatewayDomainNameAccessAssociation(string name) : TerraformResource("aws_api_gateway_domain_name_access_association", name)
{
    /// <summary>
    /// The access_association_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessAssociationSource is required")]
    public required TerraformValue<string> AccessAssociationSource
    {
        get => GetArgument<TerraformValue<string>>("access_association_source");
        set => SetArgument("access_association_source", value);
    }

    /// <summary>
    /// The access_association_source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessAssociationSourceType is required")]
    public required TerraformValue<string> AccessAssociationSourceType
    {
        get => GetArgument<TerraformValue<string>>("access_association_source_type");
        set => SetArgument("access_association_source_type", value);
    }

    /// <summary>
    /// The domain_name_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainNameArn is required")]
    public required TerraformValue<string> DomainNameArn
    {
        get => GetArgument<TerraformValue<string>>("domain_name_arn");
        set => SetArgument("domain_name_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

}
