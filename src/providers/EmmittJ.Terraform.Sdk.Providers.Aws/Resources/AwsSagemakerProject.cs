using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for service_catalog_provisioning_details in AwsSagemakerProject.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerProjectServiceCatalogProvisioningDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_catalog_provisioning_details";

    /// <summary>
    /// The path_id attribute.
    /// </summary>
    public TerraformValue<string>? PathId
    {
        get => GetArgument<TerraformValue<string>>("path_id");
        set => SetArgument("path_id", value);
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProductId is required")]
    public required TerraformValue<string> ProductId
    {
        get => GetArgument<TerraformValue<string>>("product_id");
        set => SetArgument("product_id", value);
    }

    /// <summary>
    /// The provisioning_artifact_id attribute.
    /// </summary>
    public TerraformValue<string>? ProvisioningArtifactId
    {
        get => GetArgument<TerraformValue<string>>("provisioning_artifact_id");
        set => SetArgument("provisioning_artifact_id", value);
    }

    /// <summary>
    /// ProvisioningParameter block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSagemakerProjectServiceCatalogProvisioningDetailsBlockProvisioningParameterBlock>? ProvisioningParameter
    {
        get => GetArgument<TerraformList<AwsSagemakerProjectServiceCatalogProvisioningDetailsBlockProvisioningParameterBlock>>("provisioning_parameter");
        set => SetArgument("provisioning_parameter", value);
    }

}

/// <summary>
/// Block type for provisioning_parameter in AwsSagemakerProjectServiceCatalogProvisioningDetailsBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerProjectServiceCatalogProvisioningDetailsBlockProvisioningParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "provisioning_parameter";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_sagemaker_project Terraform resource.
/// Manages a aws_sagemaker_project resource.
/// </summary>
public partial class AwsSagemakerProject(string name) : TerraformResource("aws_sagemaker_project", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project_description attribute.
    /// </summary>
    public TerraformValue<string>? ProjectDescription
    {
        get => GetArgument<TerraformValue<string>>("project_description");
        set => SetArgument("project_description", value);
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    public required TerraformValue<string> ProjectName
    {
        get => GetArgument<TerraformValue<string>>("project_name");
        set => SetArgument("project_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The project_id attribute.
    /// </summary>
    public TerraformValue<string> ProjectId
        => AsReference("project_id");

    /// <summary>
    /// ServiceCatalogProvisioningDetails block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCatalogProvisioningDetails is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ServiceCatalogProvisioningDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceCatalogProvisioningDetails block(s) allowed")]
    public required TerraformList<AwsSagemakerProjectServiceCatalogProvisioningDetailsBlock> ServiceCatalogProvisioningDetails
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerProjectServiceCatalogProvisioningDetailsBlock>>("service_catalog_provisioning_details");
        set => SetArgument("service_catalog_provisioning_details", value);
    }

}
