using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for saml_options in AwsElasticsearchDomainSamlOptions.
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainSamlOptionsSamlOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "saml_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The master_backend_role attribute.
    /// </summary>
    public TerraformValue<string>? MasterBackendRole
    {
        get => GetArgument<TerraformValue<string>>("master_backend_role");
        set => SetArgument("master_backend_role", value);
    }

    /// <summary>
    /// The master_user_name attribute.
    /// </summary>
    public TerraformValue<string>? MasterUserName
    {
        get => GetArgument<TerraformValue<string>>("master_user_name");
        set => SetArgument("master_user_name", value);
    }

    /// <summary>
    /// The roles_key attribute.
    /// </summary>
    public TerraformValue<string>? RolesKey
    {
        get => GetArgument<TerraformValue<string>>("roles_key");
        set => SetArgument("roles_key", value);
    }

    /// <summary>
    /// The session_timeout_minutes attribute.
    /// </summary>
    public TerraformValue<double>? SessionTimeoutMinutes
    {
        get => GetArgument<TerraformValue<double>>("session_timeout_minutes");
        set => SetArgument("session_timeout_minutes", value);
    }

    /// <summary>
    /// The subject_key attribute.
    /// </summary>
    public TerraformValue<string>? SubjectKey
    {
        get => GetArgument<TerraformValue<string>>("subject_key");
        set => SetArgument("subject_key", value);
    }

    /// <summary>
    /// Idp block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Idp block(s) allowed")]
    public TerraformList<AwsElasticsearchDomainSamlOptionsSamlOptionsBlockIdpBlock>? Idp
    {
        get => GetArgument<TerraformList<AwsElasticsearchDomainSamlOptionsSamlOptionsBlockIdpBlock>>("idp");
        set => SetArgument("idp", value);
    }

}

/// <summary>
/// Block type for idp in AwsElasticsearchDomainSamlOptionsSamlOptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsElasticsearchDomainSamlOptionsSamlOptionsBlockIdpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "idp";

    /// <summary>
    /// The entity_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityId is required")]
    public required TerraformValue<string> EntityId
    {
        get => GetRequiredArgument<TerraformValue<string>>("entity_id");
        set => SetArgument("entity_id", value);
    }

    /// <summary>
    /// The metadata_content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetadataContent is required")]
    public required TerraformValue<string> MetadataContent
    {
        get => GetRequiredArgument<TerraformValue<string>>("metadata_content");
        set => SetArgument("metadata_content", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsElasticsearchDomainSamlOptions.
/// Nesting mode: single
/// </summary>
public class AwsElasticsearchDomainSamlOptionsTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_elasticsearch_domain_saml_options Terraform resource.
/// Manages a aws_elasticsearch_domain_saml_options resource.
/// </summary>
public partial class AwsElasticsearchDomainSamlOptions(string name) : TerraformResource("aws_elasticsearch_domain_saml_options", name)
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
    /// SamlOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SamlOptions block(s) allowed")]
    public TerraformList<AwsElasticsearchDomainSamlOptionsSamlOptionsBlock>? SamlOptions
    {
        get => GetArgument<TerraformList<AwsElasticsearchDomainSamlOptionsSamlOptionsBlock>>("saml_options");
        set => SetArgument("saml_options", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsElasticsearchDomainSamlOptionsTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsElasticsearchDomainSamlOptionsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
