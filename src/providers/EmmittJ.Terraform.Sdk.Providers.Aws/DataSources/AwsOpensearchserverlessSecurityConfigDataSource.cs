using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for saml_options in AwsOpensearchserverlessSecurityConfigDataSource.
/// Nesting mode: list
/// </summary>
public class AwsOpensearchserverlessSecurityConfigDataSourceSamlOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "saml_options";

    /// <summary>
    /// Group attribute for this SAML integration.
    /// </summary>
    public TerraformValue<string> GroupAttribute
        => CreateReference("group_attribute");

    /// <summary>
    /// The XML IdP metadata file generated from your identity provider.
    /// </summary>
    public TerraformValue<string> Metadata
        => CreateReference("metadata");

    /// <summary>
    /// Session timeout, in minutes. Minimum is 5 minutes and maximum is 720 minutes (12 hours). Default is 60 minutes.
    /// </summary>
    public TerraformValue<double> SessionTimeout
        => CreateReference("session_timeout");

    /// <summary>
    /// User attribute for this SAML integration.
    /// </summary>
    public TerraformValue<string> UserAttribute
        => CreateReference("user_attribute");

}


/// <summary>
/// Represents a aws_opensearchserverless_security_config Terraform data source.
/// Retrieves information about a aws_opensearchserverless_security_config.
/// </summary>
public partial class AwsOpensearchserverlessSecurityConfigDataSource(string name) : TerraformDataSource("aws_opensearchserverless_security_config", name)
{
    /// <summary>
    /// The unique identifier of the security configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The version of the security configuration.
    /// </summary>
    public TerraformValue<string> ConfigVersion
        => CreateReference("config_version");

    /// <summary>
    /// The date the configuration was created.
    /// </summary>
    public TerraformValue<string> CreatedDate
        => CreateReference("created_date");

    /// <summary>
    /// The description of the security configuration.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The date the configuration was last modified.
    /// </summary>
    public TerraformValue<string> LastModifiedDate
        => CreateReference("last_modified_date");

    /// <summary>
    /// The type of security configuration.
    /// </summary>
    public TerraformValue<string> Type
        => CreateReference("type");

    /// <summary>
    /// SamlOptions block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsOpensearchserverlessSecurityConfigDataSourceSamlOptionsBlock>? SamlOptions
    {
        get => GetArgument<TerraformList<AwsOpensearchserverlessSecurityConfigDataSourceSamlOptionsBlock>>("saml_options");
        set => SetArgument("saml_options", value);
    }

}
