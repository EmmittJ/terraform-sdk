using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for provisioning_artifact_parameters in AwsServicecatalogProduct.
/// Nesting mode: list
/// </summary>
public class AwsServicecatalogProductProvisioningArtifactParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "provisioning_artifact_parameters";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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

}


/// <summary>
/// Block type for timeouts in AwsServicecatalogProduct.
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogProductTimeoutsBlock : TerraformBlock
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
/// Represents a aws_servicecatalog_product Terraform resource.
/// Manages a aws_servicecatalog_product resource.
/// </summary>
public partial class AwsServicecatalogProduct(string name) : TerraformResource("aws_servicecatalog_product", name)
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
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The distributor attribute.
    /// </summary>
    public TerraformValue<string> Distributor
    {
        get => new TerraformReference<string>(this, "distributor");
        set => SetArgument("distributor", value);
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
    /// The owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Owner is required")]
    public required TerraformValue<string> Owner
    {
        get => new TerraformReference<string>(this, "owner");
        set => SetArgument("owner", value);
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
    /// The support_description attribute.
    /// </summary>
    public TerraformValue<string> SupportDescription
    {
        get => new TerraformReference<string>(this, "support_description");
        set => SetArgument("support_description", value);
    }

    /// <summary>
    /// The support_email attribute.
    /// </summary>
    public TerraformValue<string> SupportEmail
    {
        get => new TerraformReference<string>(this, "support_email");
        set => SetArgument("support_email", value);
    }

    /// <summary>
    /// The support_url attribute.
    /// </summary>
    public TerraformValue<string> SupportUrl
    {
        get => new TerraformReference<string>(this, "support_url");
        set => SetArgument("support_url", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
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
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
    {
        get => new TerraformReference<string>(this, "created_time");
    }

    /// <summary>
    /// The has_default_path attribute.
    /// </summary>
    public TerraformValue<bool> HasDefaultPath
    {
        get => new TerraformReference<bool>(this, "has_default_path");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// ProvisioningArtifactParameters block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProvisioningArtifactParameters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProvisioningArtifactParameters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProvisioningArtifactParameters block(s) allowed")]
    public required TerraformList<AwsServicecatalogProductProvisioningArtifactParametersBlock> ProvisioningArtifactParameters
    {
        get => GetRequiredArgument<TerraformList<AwsServicecatalogProductProvisioningArtifactParametersBlock>>("provisioning_artifact_parameters");
        set => SetArgument("provisioning_artifact_parameters", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsServicecatalogProductTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsServicecatalogProductTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
