using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for trusted_token_issuer_configuration in AwsSsoadminTrustedTokenIssuer.
/// Nesting mode: list
/// </summary>
public class AwsSsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trusted_token_issuer_configuration";

    /// <summary>
    /// OidcJwtConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationBlockOidcJwtConfigurationBlock>? OidcJwtConfiguration
    {
        get => GetArgument<TerraformList<AwsSsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationBlockOidcJwtConfigurationBlock>>("oidc_jwt_configuration");
        set => SetArgument("oidc_jwt_configuration", value);
    }

}

/// <summary>
/// Block type for oidc_jwt_configuration in AwsSsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationBlockOidcJwtConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oidc_jwt_configuration";

    /// <summary>
    /// The claim_attribute_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClaimAttributePath is required")]
    public required TerraformValue<string> ClaimAttributePath
    {
        get => GetArgument<TerraformValue<string>>("claim_attribute_path");
        set => SetArgument("claim_attribute_path", value);
    }

    /// <summary>
    /// The identity_store_attribute_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreAttributePath is required")]
    public required TerraformValue<string> IdentityStoreAttributePath
    {
        get => GetArgument<TerraformValue<string>>("identity_store_attribute_path");
        set => SetArgument("identity_store_attribute_path", value);
    }

    /// <summary>
    /// The issuer_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IssuerUrl is required")]
    public required TerraformValue<string> IssuerUrl
    {
        get => GetArgument<TerraformValue<string>>("issuer_url");
        set => SetArgument("issuer_url", value);
    }

    /// <summary>
    /// The jwks_retrieval_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JwksRetrievalOption is required")]
    public required TerraformValue<string> JwksRetrievalOption
    {
        get => GetArgument<TerraformValue<string>>("jwks_retrieval_option");
        set => SetArgument("jwks_retrieval_option", value);
    }

}


/// <summary>
/// Represents a aws_ssoadmin_trusted_token_issuer Terraform resource.
/// Manages a aws_ssoadmin_trusted_token_issuer resource.
/// </summary>
public partial class AwsSsoadminTrustedTokenIssuer(string name) : TerraformResource("aws_ssoadmin_trusted_token_issuer", name)
{
    /// <summary>
    /// The client_token attribute.
    /// </summary>
    public TerraformValue<string>? ClientToken
    {
        get => GetArgument<TerraformValue<string>>("client_token");
        set => SetArgument("client_token", value);
    }

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    public required TerraformValue<string> InstanceArn
    {
        get => GetArgument<TerraformValue<string>>("instance_arn");
        set => SetArgument("instance_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The trusted_token_issuer_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustedTokenIssuerType is required")]
    public required TerraformValue<string> TrustedTokenIssuerType
    {
        get => GetArgument<TerraformValue<string>>("trusted_token_issuer_type");
        set => SetArgument("trusted_token_issuer_type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// TrustedTokenIssuerConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationBlock>? TrustedTokenIssuerConfiguration
    {
        get => GetArgument<TerraformList<AwsSsoadminTrustedTokenIssuerTrustedTokenIssuerConfigurationBlock>>("trusted_token_issuer_configuration");
        set => SetArgument("trusted_token_issuer_configuration", value);
    }

}
