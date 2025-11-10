using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for variant in .
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentPromptVariantBlock : TerraformBlock
{
    /// <summary>
    /// The additional_model_request_fields attribute.
    /// </summary>
    public TerraformProperty<string>? AdditionalModelRequestFields
    {
        set => SetProperty("additional_model_request_fields", value);
    }

    /// <summary>
    /// The model_id attribute.
    /// </summary>
    public TerraformProperty<string>? ModelId
    {
        set => SetProperty("model_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The template_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateType is required")]
    public required TerraformProperty<string> TemplateType
    {
        set => SetProperty("template_type", value);
    }

}

/// <summary>
/// Manages a aws_bedrockagent_prompt resource.
/// </summary>
public class AwsBedrockagentPrompt : TerraformResource
{
    public AwsBedrockagentPrompt(string name) : base("aws_bedrockagent_prompt", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("created_at");
        SetOutput("id");
        SetOutput("tags_all");
        SetOutput("updated_at");
        SetOutput("version");
        SetOutput("customer_encryption_key_arn");
        SetOutput("default_variant");
        SetOutput("description");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The customer_encryption_key_arn attribute.
    /// </summary>
    public TerraformProperty<string> CustomerEncryptionKeyArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_encryption_key_arn");
        set => SetProperty("customer_encryption_key_arn", value);
    }

    /// <summary>
    /// The default_variant attribute.
    /// </summary>
    public TerraformProperty<string> DefaultVariant
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_variant");
        set => SetProperty("default_variant", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for variant.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentPromptVariantBlock>? Variant
    {
        set => SetProperty("variant", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformExpression UpdatedAt => this["updated_at"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
