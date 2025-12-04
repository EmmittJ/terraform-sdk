using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for sas_configuration in AwsDatasyncLocationAzureBlob.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationAzureBlobSasConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sas_configuration";

    /// <summary>
    /// The token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Token is required")]
    public required TerraformValue<string> Token
    {
        get => GetArgument<TerraformValue<string>>("token");
        set => SetArgument("token", value);
    }

}


/// <summary>
/// Represents a aws_datasync_location_azure_blob Terraform resource.
/// Manages a aws_datasync_location_azure_blob resource.
/// </summary>
public partial class AwsDatasyncLocationAzureBlob(string name) : TerraformResource("aws_datasync_location_azure_blob", name)
{
    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    public TerraformValue<string>? AccessTier
    {
        get => GetArgument<TerraformValue<string>>("access_tier");
        set => SetArgument("access_tier", value);
    }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentArns is required")]
    public required TerraformSet<string> AgentArns
    {
        get => GetArgument<TerraformSet<string>>("agent_arns");
        set => SetArgument("agent_arns", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    public required TerraformValue<string> AuthenticationType
    {
        get => GetArgument<TerraformValue<string>>("authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The blob_type attribute.
    /// </summary>
    public TerraformValue<string>? BlobType
    {
        get => GetArgument<TerraformValue<string>>("blob_type");
        set => SetArgument("blob_type", value);
    }

    /// <summary>
    /// The container_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerUrl is required")]
    public required TerraformValue<string> ContainerUrl
    {
        get => GetArgument<TerraformValue<string>>("container_url");
        set => SetArgument("container_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The subdirectory attribute.
    /// </summary>
    public TerraformValue<string>? Subdirectory
    {
        get => GetArgument<TerraformValue<string>>("subdirectory");
        set => SetArgument("subdirectory", value);
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
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string> Uri
        => AsReference("uri");

    /// <summary>
    /// SasConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SasConfiguration block(s) allowed")]
    public TerraformList<AwsDatasyncLocationAzureBlobSasConfigurationBlock>? SasConfiguration
    {
        get => GetArgument<TerraformList<AwsDatasyncLocationAzureBlobSasConfigurationBlock>>("sas_configuration");
        set => SetArgument("sas_configuration", value);
    }

}
