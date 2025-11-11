using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for sas_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsDatasyncLocationAzureBlobSasConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Token is required")]
    [TerraformProperty("token")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Token { get; set; }

}

/// <summary>
/// Manages a aws_datasync_location_azure_blob resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDatasyncLocationAzureBlob : TerraformResource
{
    public AwsDatasyncLocationAzureBlob(string name) : base("aws_datasync_location_azure_blob", name)
    {
    }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    [TerraformProperty("access_tier")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AccessTier { get; set; }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentArns is required")]
    [TerraformProperty("agent_arns")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> AgentArns { get; set; }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    [TerraformProperty("authentication_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AuthenticationType { get; set; }

    /// <summary>
    /// The blob_type attribute.
    /// </summary>
    [TerraformProperty("blob_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BlobType { get; set; }

    /// <summary>
    /// The container_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerUrl is required")]
    [TerraformProperty("container_url")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ContainerUrl { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    [TerraformProperty("subdirectory")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Subdirectory { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for sas_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SasConfiguration block(s) allowed")]
    [TerraformProperty("sas_configuration")]
    public TerraformList<TerraformBlock<AwsDatasyncLocationAzureBlobSasConfigurationBlock>>? SasConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformProperty("uri")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Uri { get; }

}
