using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_route53_resolver_query_log_config_association Terraform resource.
/// Manages a aws_route53_resolver_query_log_config_association resource.
/// </summary>
public partial class AwsRoute53ResolverQueryLogConfigAssociation(string name) : TerraformResource("aws_route53_resolver_query_log_config_association", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resolver_query_log_config_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResolverQueryLogConfigId is required")]
    public required TerraformValue<string> ResolverQueryLogConfigId
    {
        get => GetRequiredArgument<TerraformValue<string>>("resolver_query_log_config_id");
        set => SetArgument("resolver_query_log_config_id", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformValue<string> ResourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_id");
        set => SetArgument("resource_id", value);
    }

}
