using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for saml_options in AwsOpensearchDomainSamlOptions.
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainSamlOptionsSamlOptionsBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The master_backend_role attribute.
    /// </summary>
    public TerraformValue<string>? MasterBackendRole
    {
        get => new TerraformReference<string>(this, "master_backend_role");
        set => SetArgument("master_backend_role", value);
    }

    /// <summary>
    /// The master_user_name attribute.
    /// </summary>
    public TerraformValue<string>? MasterUserName
    {
        get => new TerraformReference<string>(this, "master_user_name");
        set => SetArgument("master_user_name", value);
    }

    /// <summary>
    /// The roles_key attribute.
    /// </summary>
    public TerraformValue<string>? RolesKey
    {
        get => new TerraformReference<string>(this, "roles_key");
        set => SetArgument("roles_key", value);
    }

    /// <summary>
    /// The session_timeout_minutes attribute.
    /// </summary>
    public TerraformValue<double>? SessionTimeoutMinutes
    {
        get => new TerraformReference<double>(this, "session_timeout_minutes");
        set => SetArgument("session_timeout_minutes", value);
    }

    /// <summary>
    /// The subject_key attribute.
    /// </summary>
    public TerraformValue<string>? SubjectKey
    {
        get => new TerraformReference<string>(this, "subject_key");
        set => SetArgument("subject_key", value);
    }

    /// <summary>
    /// Idp block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Idp block(s) allowed")]
    public TerraformList<AwsOpensearchDomainSamlOptionsSamlOptionsBlockIdpBlock>? Idp
    {
        get => GetArgument<TerraformList<AwsOpensearchDomainSamlOptionsSamlOptionsBlockIdpBlock>>("idp");
        set => SetArgument("idp", value);
    }

}

/// <summary>
/// Block type for idp in AwsOpensearchDomainSamlOptionsSamlOptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainSamlOptionsSamlOptionsBlockIdpBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "entity_id");
        set => SetArgument("entity_id", value);
    }

    /// <summary>
    /// The metadata_content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetadataContent is required")]
    public required TerraformValue<string> MetadataContent
    {
        get => new TerraformReference<string>(this, "metadata_content");
        set => SetArgument("metadata_content", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsOpensearchDomainSamlOptions.
/// Nesting mode: single
/// </summary>
public class AwsOpensearchDomainSamlOptionsTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_opensearch_domain_saml_options Terraform resource.
/// Manages a aws_opensearch_domain_saml_options resource.
/// </summary>
public partial class AwsOpensearchDomainSamlOptions(string name) : TerraformResource("aws_opensearch_domain_saml_options", name)
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// SamlOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SamlOptions block(s) allowed")]
    public TerraformList<AwsOpensearchDomainSamlOptionsSamlOptionsBlock>? SamlOptions
    {
        get => GetArgument<TerraformList<AwsOpensearchDomainSamlOptionsSamlOptionsBlock>>("saml_options");
        set => SetArgument("saml_options", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsOpensearchDomainSamlOptionsTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsOpensearchDomainSamlOptionsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
