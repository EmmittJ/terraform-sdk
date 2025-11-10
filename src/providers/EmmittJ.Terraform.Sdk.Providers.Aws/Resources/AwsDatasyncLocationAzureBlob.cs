using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for sas_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationAzureBlobSasConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Token is required")]
    public required TerraformProperty<string> Token
    {
        set => SetProperty("token", value);
    }

}

/// <summary>
/// Manages a aws_datasync_location_azure_blob resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDatasyncLocationAzureBlob : TerraformResource
{
    public AwsDatasyncLocationAzureBlob(string name) : base("aws_datasync_location_azure_blob", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("uri");
        SetOutput("access_tier");
        SetOutput("agent_arns");
        SetOutput("authentication_type");
        SetOutput("blob_type");
        SetOutput("container_url");
        SetOutput("id");
        SetOutput("region");
        SetOutput("subdirectory");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The access_tier attribute.
    /// </summary>
    public TerraformProperty<string> AccessTier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_tier");
        set => SetProperty("access_tier", value);
    }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AgentArns is required")]
    public HashSet<TerraformProperty<string>> AgentArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("agent_arns");
        set => SetProperty("agent_arns", value);
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    public required TerraformProperty<string> AuthenticationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_type");
        set => SetProperty("authentication_type", value);
    }

    /// <summary>
    /// The blob_type attribute.
    /// </summary>
    public TerraformProperty<string> BlobType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("blob_type");
        set => SetProperty("blob_type", value);
    }

    /// <summary>
    /// The container_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerUrl is required")]
    public required TerraformProperty<string> ContainerUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_url");
        set => SetProperty("container_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    public TerraformProperty<string> Subdirectory
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subdirectory");
        set => SetProperty("subdirectory", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for sas_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SasConfiguration block(s) allowed")]
    public List<AwsDatasyncLocationAzureBlobSasConfigurationBlock>? SasConfiguration
    {
        set => SetProperty("sas_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformExpression Uri => this["uri"];

}
