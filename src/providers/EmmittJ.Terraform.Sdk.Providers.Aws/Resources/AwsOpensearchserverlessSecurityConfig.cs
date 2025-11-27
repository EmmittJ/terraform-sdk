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
        get => new TerraformReference<string>(this, "group_attribute");
        set => SetArgument("group_attribute", value);
    }

    /// <summary>
    /// The XML IdP metadata file generated from your identity provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Metadata is required")]
    public required TerraformValue<string> Metadata
    {
        get => new TerraformReference<string>(this, "metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// Session timeout, in minutes. Minimum is 5 minutes and maximum is 720 minutes (12 hours). Default is 60 minutes.
    /// </summary>
    public TerraformValue<double> SessionTimeout
    {
        get => new TerraformReference<double>(this, "session_timeout");
        set => SetArgument("session_timeout", value);
    }

    /// <summary>
    /// User attribute for this SAML integration.
    /// </summary>
    public TerraformValue<string>? UserAttribute
    {
        get => new TerraformReference<string>(this, "user_attribute");
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
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Name of the policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Type of configuration. Must be `saml`.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Version of the configuration.
    /// </summary>
    public TerraformValue<string> ConfigVersion
    {
        get => new TerraformReference<string>(this, "config_version");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// SamlOptions block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsOpensearchserverlessSecurityConfigSamlOptionsBlock>? SamlOptions
    {
        get => GetArgument<TerraformList<AwsOpensearchserverlessSecurityConfigSamlOptionsBlock>>("saml_options");
        set => SetArgument("saml_options", value);
    }

}
