using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for saml_options in AwsOpensearchserverlessSecurityConfig.
/// Nesting mode: list
/// </summary>
public class AwsOpensearchserverlessSecurityConfigSamlOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "saml_options";

    /// <summary>
    /// Group attribute for this SAML integration.
    /// </summary>
    public TerraformValue<string>? GroupAttribute
    {
        get => GetArgument<TerraformValue<string>>("group_attribute");
        set => SetArgument("group_attribute", value);
    }

    /// <summary>
    /// The XML IdP metadata file generated from your identity provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metadata is required")]
    public required TerraformValue<string> Metadata
    {
        get => GetArgument<TerraformValue<string>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// Session timeout, in minutes. Minimum is 5 minutes and maximum is 720 minutes (12 hours). Default is 60 minutes.
    /// </summary>
    public TerraformValue<double>? SessionTimeout
    {
        get => GetArgument<TerraformValue<double>>("session_timeout");
        set => SetArgument("session_timeout", value);
    }

    /// <summary>
    /// User attribute for this SAML integration.
    /// </summary>
    public TerraformValue<string>? UserAttribute
    {
        get => GetArgument<TerraformValue<string>>("user_attribute");
        set => SetArgument("user_attribute", value);
    }

}


/// <summary>
/// Represents a aws_opensearchserverless_security_config Terraform resource.
/// Manages a aws_opensearchserverless_security_config resource.
/// </summary>
public partial class AwsOpensearchserverlessSecurityConfig(string name) : TerraformResource("aws_opensearchserverless_security_config", name)
{
    /// <summary>
    /// Description of the security configuration.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Name of the policy.
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
    /// Type of configuration. Must be `saml`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Version of the configuration.
    /// </summary>
    public TerraformValue<string> ConfigVersion
        => AsReference("config_version");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// SamlOptions block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsOpensearchserverlessSecurityConfigSamlOptionsBlock>? SamlOptions
    {
        get => GetArgument<TerraformList<AwsOpensearchserverlessSecurityConfigSamlOptionsBlock>>("saml_options");
        set => SetArgument("saml_options", value);
    }

}
