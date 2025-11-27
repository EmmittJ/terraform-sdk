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
        get => new TerraformReference<string>(this, "token");
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
        get => new TerraformReference<string>(this, "access_tier");
        set => SetArgument("access_tier", value);
    }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentArns is required")]
    public required TerraformSet<string> AgentArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "agent_arns").ResolveNodes(ctx));
        set => SetArgument("agent_arns", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    public required TerraformValue<string> AuthenticationType
    {
        get => new TerraformReference<string>(this, "authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The blob_type attribute.
    /// </summary>
    public TerraformValue<string>? BlobType
    {
        get => new TerraformReference<string>(this, "blob_type");
        set => SetArgument("blob_type", value);
    }

    /// <summary>
    /// The container_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerUrl is required")]
    public required TerraformValue<string> ContainerUrl
    {
        get => new TerraformReference<string>(this, "container_url");
        set => SetArgument("container_url", value);
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
    /// The subdirectory attribute.
    /// </summary>
    public TerraformValue<string> Subdirectory
    {
        get => new TerraformReference<string>(this, "subdirectory");
        set => SetArgument("subdirectory", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
    }

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
