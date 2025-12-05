using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for identity_provider_details in AwsTransferWebApp.
/// Nesting mode: list
/// </summary>
public class AwsTransferWebAppIdentityProviderDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity_provider_details";

    /// <summary>
    /// IdentityCenterConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTransferWebAppIdentityProviderDetailsBlockIdentityCenterConfigBlock>? IdentityCenterConfig
    {
        get => GetArgument<TerraformList<AwsTransferWebAppIdentityProviderDetailsBlockIdentityCenterConfigBlock>>("identity_center_config");
        set => SetArgument("identity_center_config", value);
    }

}

/// <summary>
/// Block type for identity_center_config in AwsTransferWebAppIdentityProviderDetailsBlock.
/// Nesting mode: list
/// </summary>
public class AwsTransferWebAppIdentityProviderDetailsBlockIdentityCenterConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity_center_config";

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    public TerraformValue<string> ApplicationArn
        => CreateReference("application_arn");

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    public TerraformValue<string>? InstanceArn
    {
        get => GetArgument<TerraformValue<string>>("instance_arn");
        set => SetArgument("instance_arn", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    public TerraformValue<string>? Role
    {
        get => GetArgument<TerraformValue<string>>("role");
        set => SetArgument("role", value);
    }

}


/// <summary>
/// Represents a aws_transfer_web_app Terraform resource.
/// Manages a aws_transfer_web_app resource.
/// </summary>
public partial class AwsTransferWebApp(string name) : TerraformResource("aws_transfer_web_app", name)
{
    /// <summary>
    /// The access_endpoint attribute.
    /// </summary>
    public TerraformValue<string> AccessEndpoint
    {
        get => GetArgument<TerraformValue<string>>("access_endpoint") ?? CreateReference("access_endpoint");
        set => SetArgument("access_endpoint", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
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
    /// The web_app_endpoint_policy attribute.
    /// </summary>
    public TerraformValue<string> WebAppEndpointPolicy
    {
        get => GetArgument<TerraformValue<string>>("web_app_endpoint_policy") ?? CreateReference("web_app_endpoint_policy");
        set => SetArgument("web_app_endpoint_policy", value);
    }

    /// <summary>
    /// The web_app_units attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> WebAppUnits
    {
        get => GetArgument<TerraformList<TerraformMap<object>>>("web_app_units") ?? CreateReference("web_app_units");
        set => SetArgument("web_app_units", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

    /// <summary>
    /// The web_app_id attribute.
    /// </summary>
    public TerraformValue<string> WebAppId
        => CreateReference("web_app_id");

    /// <summary>
    /// IdentityProviderDetails block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsTransferWebAppIdentityProviderDetailsBlock>? IdentityProviderDetails
    {
        get => GetArgument<TerraformList<AwsTransferWebAppIdentityProviderDetailsBlock>>("identity_provider_details");
        set => SetArgument("identity_provider_details", value);
    }

}
