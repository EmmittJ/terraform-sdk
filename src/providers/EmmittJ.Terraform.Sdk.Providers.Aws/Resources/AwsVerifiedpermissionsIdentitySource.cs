using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in AwsVerifiedpermissionsIdentitySource.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsIdentitySourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration";

    /// <summary>
    /// CognitoUserPoolConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVerifiedpermissionsIdentitySourceConfigurationBlockCognitoUserPoolConfigurationBlock>? CognitoUserPoolConfiguration
    {
        get => GetArgument<TerraformList<AwsVerifiedpermissionsIdentitySourceConfigurationBlockCognitoUserPoolConfigurationBlock>>("cognito_user_pool_configuration");
        set => SetArgument("cognito_user_pool_configuration", value);
    }

    /// <summary>
    /// OpenIdConnectConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVerifiedpermissionsIdentitySourceConfigurationBlockOpenIdConnectConfigurationBlock>? OpenIdConnectConfiguration
    {
        get => GetArgument<TerraformList<AwsVerifiedpermissionsIdentitySourceConfigurationBlockOpenIdConnectConfigurationBlock>>("open_id_connect_configuration");
        set => SetArgument("open_id_connect_configuration", value);
    }

}

/// <summary>
/// Block type for cognito_user_pool_configuration in AwsVerifiedpermissionsIdentitySourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsIdentitySourceConfigurationBlockCognitoUserPoolConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cognito_user_pool_configuration";

    /// <summary>
    /// The client_ids attribute.
    /// </summary>
    public TerraformList<string> ClientIds
    {
        get => GetArgument<TerraformList<string>>("client_ids") ?? CreateReference("client_ids");
        set => SetArgument("client_ids", value);
    }

    /// <summary>
    /// The user_pool_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolArn is required")]
    public required TerraformValue<string> UserPoolArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_pool_arn");
        set => SetArgument("user_pool_arn", value);
    }

    /// <summary>
    /// GroupConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVerifiedpermissionsIdentitySourceConfigurationBlockCognitoUserPoolConfigurationBlockGroupConfigurationBlock>? GroupConfiguration
    {
        get => GetArgument<TerraformList<AwsVerifiedpermissionsIdentitySourceConfigurationBlockCognitoUserPoolConfigurationBlockGroupConfigurationBlock>>("group_configuration");
        set => SetArgument("group_configuration", value);
    }

}

/// <summary>
/// Block type for group_configuration in AwsVerifiedpermissionsIdentitySourceConfigurationBlockCognitoUserPoolConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsIdentitySourceConfigurationBlockCognitoUserPoolConfigurationBlockGroupConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "group_configuration";

    /// <summary>
    /// The group_entity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupEntityType is required")]
    public required TerraformValue<string> GroupEntityType
    {
        get => GetRequiredArgument<TerraformValue<string>>("group_entity_type");
        set => SetArgument("group_entity_type", value);
    }

}

/// <summary>
/// Block type for open_id_connect_configuration in AwsVerifiedpermissionsIdentitySourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsIdentitySourceConfigurationBlockOpenIdConnectConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "open_id_connect_configuration";

    /// <summary>
    /// The entity_id_prefix attribute.
    /// </summary>
    public TerraformValue<string>? EntityIdPrefix
    {
        get => GetArgument<TerraformValue<string>>("entity_id_prefix");
        set => SetArgument("entity_id_prefix", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformValue<string> Issuer
    {
        get => GetRequiredArgument<TerraformValue<string>>("issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// GroupConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVerifiedpermissionsIdentitySourceConfigurationBlockOpenIdConnectConfigurationBlockGroupConfigurationBlock>? GroupConfiguration
    {
        get => GetArgument<TerraformList<AwsVerifiedpermissionsIdentitySourceConfigurationBlockOpenIdConnectConfigurationBlockGroupConfigurationBlock>>("group_configuration");
        set => SetArgument("group_configuration", value);
    }

    /// <summary>
    /// TokenSelection block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVerifiedpermissionsIdentitySourceConfigurationBlockOpenIdConnectConfigurationBlockTokenSelectionBlock>? TokenSelection
    {
        get => GetArgument<TerraformList<AwsVerifiedpermissionsIdentitySourceConfigurationBlockOpenIdConnectConfigurationBlockTokenSelectionBlock>>("token_selection");
        set => SetArgument("token_selection", value);
    }

}

/// <summary>
/// Block type for group_configuration in AwsVerifiedpermissionsIdentitySourceConfigurationBlockOpenIdConnectConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsIdentitySourceConfigurationBlockOpenIdConnectConfigurationBlockGroupConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "group_configuration";

    /// <summary>
    /// The group_claim attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupClaim is required")]
    public required TerraformValue<string> GroupClaim
    {
        get => GetRequiredArgument<TerraformValue<string>>("group_claim");
        set => SetArgument("group_claim", value);
    }

    /// <summary>
    /// The group_entity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupEntityType is required")]
    public required TerraformValue<string> GroupEntityType
    {
        get => GetRequiredArgument<TerraformValue<string>>("group_entity_type");
        set => SetArgument("group_entity_type", value);
    }

}

/// <summary>
/// Block type for token_selection in AwsVerifiedpermissionsIdentitySourceConfigurationBlockOpenIdConnectConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsIdentitySourceConfigurationBlockOpenIdConnectConfigurationBlockTokenSelectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "token_selection";

    /// <summary>
    /// AccessTokenOnly block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVerifiedpermissionsIdentitySourceConfigurationBlockOpenIdConnectConfigurationBlockTokenSelectionBlockAccessTokenOnlyBlock>? AccessTokenOnly
    {
        get => GetArgument<TerraformList<AwsVerifiedpermissionsIdentitySourceConfigurationBlockOpenIdConnectConfigurationBlockTokenSelectionBlockAccessTokenOnlyBlock>>("access_token_only");
        set => SetArgument("access_token_only", value);
    }

    /// <summary>
    /// IdentityTokenOnly block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVerifiedpermissionsIdentitySourceConfigurationBlockOpenIdConnectConfigurationBlockTokenSelectionBlockIdentityTokenOnlyBlock>? IdentityTokenOnly
    {
        get => GetArgument<TerraformList<AwsVerifiedpermissionsIdentitySourceConfigurationBlockOpenIdConnectConfigurationBlockTokenSelectionBlockIdentityTokenOnlyBlock>>("identity_token_only");
        set => SetArgument("identity_token_only", value);
    }

}

/// <summary>
/// Block type for access_token_only in AwsVerifiedpermissionsIdentitySourceConfigurationBlockOpenIdConnectConfigurationBlockTokenSelectionBlock.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsIdentitySourceConfigurationBlockOpenIdConnectConfigurationBlockTokenSelectionBlockAccessTokenOnlyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_token_only";

    /// <summary>
    /// The audiences attribute.
    /// </summary>
    public TerraformList<string>? Audiences
    {
        get => GetArgument<TerraformList<string>>("audiences");
        set => SetArgument("audiences", value);
    }

    /// <summary>
    /// The principal_id_claim attribute.
    /// </summary>
    public TerraformValue<string>? PrincipalIdClaim
    {
        get => GetArgument<TerraformValue<string>>("principal_id_claim");
        set => SetArgument("principal_id_claim", value);
    }

}

/// <summary>
/// Block type for identity_token_only in AwsVerifiedpermissionsIdentitySourceConfigurationBlockOpenIdConnectConfigurationBlockTokenSelectionBlock.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsIdentitySourceConfigurationBlockOpenIdConnectConfigurationBlockTokenSelectionBlockIdentityTokenOnlyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity_token_only";

    /// <summary>
    /// The client_ids attribute.
    /// </summary>
    public TerraformList<string>? ClientIds
    {
        get => GetArgument<TerraformList<string>>("client_ids");
        set => SetArgument("client_ids", value);
    }

    /// <summary>
    /// The principal_id_claim attribute.
    /// </summary>
    public TerraformValue<string>? PrincipalIdClaim
    {
        get => GetArgument<TerraformValue<string>>("principal_id_claim");
        set => SetArgument("principal_id_claim", value);
    }

}


/// <summary>
/// Represents a aws_verifiedpermissions_identity_source Terraform resource.
/// Manages a aws_verifiedpermissions_identity_source resource.
/// </summary>
public partial class AwsVerifiedpermissionsIdentitySource(string name) : TerraformResource("aws_verifiedpermissions_identity_source", name)
{
    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyStoreId is required")]
    public required TerraformValue<string> PolicyStoreId
    {
        get => GetRequiredArgument<TerraformValue<string>>("policy_store_id");
        set => SetArgument("policy_store_id", value);
    }

    /// <summary>
    /// The principal_entity_type attribute.
    /// </summary>
    public TerraformValue<string> PrincipalEntityType
    {
        get => GetArgument<TerraformValue<string>>("principal_entity_type") ?? CreateReference("principal_entity_type");
        set => SetArgument("principal_entity_type", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// Configuration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVerifiedpermissionsIdentitySourceConfigurationBlock>? Configuration
    {
        get => GetArgument<TerraformList<AwsVerifiedpermissionsIdentitySourceConfigurationBlock>>("configuration");
        set => SetArgument("configuration", value);
    }

}
