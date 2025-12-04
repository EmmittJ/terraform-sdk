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
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The disable_template_validation attribute.
    /// </summary>
    public TerraformValue<bool>? DisableTemplateValidation
    {
        get => GetArgument<TerraformValue<bool>>("disable_template_validation");
        set => SetArgument("disable_template_validation", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The template_physical_id attribute.
    /// </summary>
    public TerraformValue<string>? TemplatePhysicalId
    {
        get => GetArgument<TerraformValue<string>>("template_physical_id");
        set => SetArgument("template_physical_id", value);
    }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    public TerraformValue<string>? TemplateUrl
    {
        get => GetArgument<TerraformValue<string>>("template_url");
        set => SetArgument("template_url", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
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
        get => GetArgument<TerraformValue<string>>("accept_language");
        set => SetArgument("accept_language", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => GetArgument<TerraformValue<string>>("description") ?? AsReference("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The distributor attribute.
    /// </summary>
    public TerraformValue<string> Distributor
    {
        get => GetArgument<TerraformValue<string>>("distributor") ?? AsReference("distributor");
        set => SetArgument("distributor", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Owner is required")]
    public required TerraformValue<string> Owner
    {
        get => GetRequiredArgument<TerraformValue<string>>("owner");
        set => SetArgument("owner", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The support_description attribute.
    /// </summary>
    public TerraformValue<string> SupportDescription
    {
        get => GetArgument<TerraformValue<string>>("support_description") ?? AsReference("support_description");
        set => SetArgument("support_description", value);
    }

    /// <summary>
    /// The support_email attribute.
    /// </summary>
    public TerraformValue<string> SupportEmail
    {
        get => GetArgument<TerraformValue<string>>("support_email") ?? AsReference("support_email");
        set => SetArgument("support_email", value);
    }

    /// <summary>
    /// The support_url attribute.
    /// </summary>
    public TerraformValue<string> SupportUrl
    {
        get => GetArgument<TerraformValue<string>>("support_url") ?? AsReference("support_url");
        set => SetArgument("support_url", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    public TerraformValue<string> CreatedTime
        => AsReference("created_time");

    /// <summary>
    /// The has_default_path attribute.
    /// </summary>
    public TerraformValue<bool> HasDefaultPath
        => AsReference("has_default_path");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

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
