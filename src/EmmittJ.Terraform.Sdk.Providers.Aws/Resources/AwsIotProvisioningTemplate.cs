using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for pre_provisioning_hook in .
/// Nesting mode: list
/// </summary>
public class AwsIotProvisioningTemplatePreProvisioningHookBlock : TerraformBlock
{
    /// <summary>
    /// The payload_version attribute.
    /// </summary>
    public TerraformProperty<string>? PayloadVersion
    {
        get => GetProperty<TerraformProperty<string>>("payload_version");
        set => WithProperty("payload_version", value);
    }

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetArn is required")]
    public required TerraformProperty<string> TargetArn
    {
        get => GetProperty<TerraformProperty<string>>("target_arn");
        set => WithProperty("target_arn", value);
    }

}

/// <summary>
/// Manages a aws_iot_provisioning_template resource.
/// </summary>
public class AwsIotProvisioningTemplate : TerraformResource
{
    public AwsIotProvisioningTemplate(string name) : base("aws_iot_provisioning_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("default_version_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The provisioning_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProvisioningRoleArn is required")]
    public required TerraformProperty<string> ProvisioningRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("provisioning_role_arn");
        set => this.WithProperty("provisioning_role_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateBody is required")]
    public required TerraformProperty<string> TemplateBody
    {
        get => GetProperty<TerraformProperty<string>>("template_body");
        set => this.WithProperty("template_body", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for pre_provisioning_hook.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreProvisioningHook block(s) allowed")]
    public List<AwsIotProvisioningTemplatePreProvisioningHookBlock>? PreProvisioningHook
    {
        get => GetProperty<List<AwsIotProvisioningTemplatePreProvisioningHookBlock>>("pre_provisioning_hook");
        set => this.WithProperty("pre_provisioning_hook", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The default_version_id attribute.
    /// </summary>
    public TerraformExpression DefaultVersionId => this["default_version_id"];

}
