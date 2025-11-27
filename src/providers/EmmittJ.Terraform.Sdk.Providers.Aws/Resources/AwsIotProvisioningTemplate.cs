using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for pre_provisioning_hook in AwsIotProvisioningTemplate.
/// Nesting mode: list
/// </summary>
public class AwsIotProvisioningTemplatePreProvisioningHookBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pre_provisioning_hook";

    /// <summary>
    /// The payload_version attribute.
    /// </summary>
    public TerraformValue<string>? PayloadVersion
    {
        get => new TerraformReference<string>(this, "payload_version");
        set => SetArgument("payload_version", value);
    }

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetArn is required")]
    public required TerraformValue<string> TargetArn
    {
        get => new TerraformReference<string>(this, "target_arn");
        set => SetArgument("target_arn", value);
    }

}


/// <summary>
/// Represents a aws_iot_provisioning_template Terraform resource.
/// Manages a aws_iot_provisioning_template resource.
/// </summary>
public partial class AwsIotProvisioningTemplate(string name) : TerraformResource("aws_iot_provisioning_template", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The provisioning_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProvisioningRoleArn is required")]
    public required TerraformValue<string> ProvisioningRoleArn
    {
        get => new TerraformReference<string>(this, "provisioning_role_arn");
        set => SetArgument("provisioning_role_arn", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateBody is required")]
    public required TerraformValue<string> TemplateBody
    {
        get => new TerraformReference<string>(this, "template_body");
        set => SetArgument("template_body", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The default_version_id attribute.
    /// </summary>
    public TerraformValue<double> DefaultVersionId
    {
        get => new TerraformReference<double>(this, "default_version_id");
    }

    /// <summary>
    /// PreProvisioningHook block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreProvisioningHook block(s) allowed")]
    public TerraformList<AwsIotProvisioningTemplatePreProvisioningHookBlock>? PreProvisioningHook
    {
        get => GetArgument<TerraformList<AwsIotProvisioningTemplatePreProvisioningHookBlock>>("pre_provisioning_hook");
        set => SetArgument("pre_provisioning_hook", value);
    }

}
