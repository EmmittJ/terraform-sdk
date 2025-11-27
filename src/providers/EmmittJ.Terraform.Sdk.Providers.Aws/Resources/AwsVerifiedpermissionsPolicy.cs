using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for definition in AwsVerifiedpermissionsPolicy.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsPolicyDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "definition";

    /// <summary>
    /// StaticAttribute block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVerifiedpermissionsPolicyDefinitionBlockStaticAttributeBlock>? StaticAttribute
    {
        get => GetArgument<TerraformList<AwsVerifiedpermissionsPolicyDefinitionBlockStaticAttributeBlock>>("static");
        set => SetArgument("static", value);
    }

    /// <summary>
    /// TemplateLinked block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVerifiedpermissionsPolicyDefinitionBlockTemplateLinkedBlock>? TemplateLinked
    {
        get => GetArgument<TerraformList<AwsVerifiedpermissionsPolicyDefinitionBlockTemplateLinkedBlock>>("template_linked");
        set => SetArgument("template_linked", value);
    }

}

/// <summary>
/// Block type for static in AwsVerifiedpermissionsPolicyDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsPolicyDefinitionBlockStaticAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "static";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The statement attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Statement is required")]
    public required TerraformValue<string> Statement
    {
        get => new TerraformReference<string>(this, "statement");
        set => SetArgument("statement", value);
    }

}

/// <summary>
/// Block type for template_linked in AwsVerifiedpermissionsPolicyDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsPolicyDefinitionBlockTemplateLinkedBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "template_linked";

    /// <summary>
    /// The policy_template_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyTemplateId is required")]
    public required TerraformValue<string> PolicyTemplateId
    {
        get => new TerraformReference<string>(this, "policy_template_id");
        set => SetArgument("policy_template_id", value);
    }

    /// <summary>
    /// Principal block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVerifiedpermissionsPolicyDefinitionBlockTemplateLinkedBlockPrincipalBlock>? Principal
    {
        get => GetArgument<TerraformList<AwsVerifiedpermissionsPolicyDefinitionBlockTemplateLinkedBlockPrincipalBlock>>("principal");
        set => SetArgument("principal", value);
    }

    /// <summary>
    /// Resource block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVerifiedpermissionsPolicyDefinitionBlockTemplateLinkedBlockResourceBlock>? Resource
    {
        get => GetArgument<TerraformList<AwsVerifiedpermissionsPolicyDefinitionBlockTemplateLinkedBlockResourceBlock>>("resource");
        set => SetArgument("resource", value);
    }

}

/// <summary>
/// Block type for principal in AwsVerifiedpermissionsPolicyDefinitionBlockTemplateLinkedBlock.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsPolicyDefinitionBlockTemplateLinkedBlockPrincipalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "principal";

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
    /// The entity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityType is required")]
    public required TerraformValue<string> EntityType
    {
        get => new TerraformReference<string>(this, "entity_type");
        set => SetArgument("entity_type", value);
    }

}

/// <summary>
/// Block type for resource in AwsVerifiedpermissionsPolicyDefinitionBlockTemplateLinkedBlock.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedpermissionsPolicyDefinitionBlockTemplateLinkedBlockResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource";

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
    /// The entity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityType is required")]
    public required TerraformValue<string> EntityType
    {
        get => new TerraformReference<string>(this, "entity_type");
        set => SetArgument("entity_type", value);
    }

}


/// <summary>
/// Represents a aws_verifiedpermissions_policy Terraform resource.
/// Manages a aws_verifiedpermissions_policy resource.
/// </summary>
public partial class AwsVerifiedpermissionsPolicy(string name) : TerraformResource("aws_verifiedpermissions_policy", name)
{
    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyStoreId is required")]
    public required TerraformValue<string> PolicyStoreId
    {
        get => new TerraformReference<string>(this, "policy_store_id");
        set => SetArgument("policy_store_id", value);
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
    /// The created_date attribute.
    /// </summary>
    public TerraformValue<string> CreatedDate
    {
        get => new TerraformReference<string>(this, "created_date");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The policy_id attribute.
    /// </summary>
    public TerraformValue<string> PolicyId
    {
        get => new TerraformReference<string>(this, "policy_id");
    }

    /// <summary>
    /// Definition block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsVerifiedpermissionsPolicyDefinitionBlock>? Definition
    {
        get => GetArgument<TerraformList<AwsVerifiedpermissionsPolicyDefinitionBlock>>("definition");
        set => SetArgument("definition", value);
    }

}
