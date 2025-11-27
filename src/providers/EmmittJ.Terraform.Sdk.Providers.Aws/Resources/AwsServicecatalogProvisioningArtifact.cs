using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsServicecatalogProvisioningArtifact.
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogProvisioningArtifactTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
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
/// Represents a aws_servicecatalog_provisioning_artifact Terraform resource.
/// Manages a aws_servicecatalog_provisioning_artifact resource.
/// </summary>
public partial class AwsServicecatalogProvisioningArtifact(string name) : TerraformResource("aws_servicecatalog_provisioning_artifact", name)
{
    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    public TerraformValue<string>? AcceptLanguage
    {
        get => new TerraformReference<string>(this, "accept_language");
        set => SetArgument("accept_language", value);
    }

    /// <summary>
    /// The active attribute.
    /// </summary>
    public TerraformValue<bool>? Active
    {
        get => new TerraformReference<bool>(this, "active");
        set => SetArgument("active", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The disable_template_validation attribute.
    /// </summary>
    public TerraformValue<bool>? DisableTemplateValidation
    {
        get => new TerraformReference<bool>(this, "disable_template_validation");
        set => SetArgument("disable_template_validation", value);
    }

    /// <summary>
    /// The guidance attribute.
    /// </summary>
    public TerraformValue<string>? Guidance
    {
        get => new TerraformReference<string>(this, "guidance");
        set => SetArgument("guidance", value);
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
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductId is required")]
    public required TerraformValue<string> ProductId
    {
        get => new TerraformReference<string>(this, "product_id");
        set => SetArgument("product_id", value);
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
    /// The template_physical_id attribute.
    /// </summary>
    public TerraformValue<string>? TemplatePhysicalId
    {
        get => new TerraformReference<string>(this, "template_physical_id");
        set => SetArgument("template_physical_id", value);
    }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    public TerraformValue<string>? TemplateUrl
    {
        get => new TerraformReference<string>(this, "template_url");
        set => SetArgument("template_url", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
    {
        get => new TerraformReference<string>(this, "created_time");
    }

    /// <summary>
    /// The provisioning_artifact_id attribute.
    /// </summary>
    public TerraformValue<string> ProvisioningArtifactId
    {
        get => new TerraformReference<string>(this, "provisioning_artifact_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsServicecatalogProvisioningArtifactTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsServicecatalogProvisioningArtifactTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
