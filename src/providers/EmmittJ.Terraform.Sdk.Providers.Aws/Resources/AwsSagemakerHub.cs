using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for s3_storage_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerHubS3StorageConfigBlock : TerraformBlock
{
    /// <summary>
    /// The s3_output_path attribute.
    /// </summary>
    public TerraformProperty<string>? S3OutputPath
    {
        set => SetProperty("s3_output_path", value);
    }

}

/// <summary>
/// Manages a aws_sagemaker_hub resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerHub : TerraformResource
{
    public AwsSagemakerHub(string name) : base("aws_sagemaker_hub", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("hub_description");
        SetOutput("hub_display_name");
        SetOutput("hub_name");
        SetOutput("hub_search_keywords");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The hub_description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HubDescription is required")]
    public required TerraformProperty<string> HubDescription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hub_description");
        set => SetProperty("hub_description", value);
    }

    /// <summary>
    /// The hub_display_name attribute.
    /// </summary>
    public TerraformProperty<string> HubDisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hub_display_name");
        set => SetProperty("hub_display_name", value);
    }

    /// <summary>
    /// The hub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HubName is required")]
    public required TerraformProperty<string> HubName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hub_name");
        set => SetProperty("hub_name", value);
    }

    /// <summary>
    /// The hub_search_keywords attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> HubSearchKeywords
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("hub_search_keywords");
        set => SetProperty("hub_search_keywords", value);
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
    /// Block for s3_storage_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3StorageConfig block(s) allowed")]
    public List<AwsSagemakerHubS3StorageConfigBlock>? S3StorageConfig
    {
        set => SetProperty("s3_storage_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
