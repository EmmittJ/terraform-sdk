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
        get => GetProperty<TerraformProperty<string>>("additional_model_request_fields");
        set => WithProperty("additional_model_request_fields", value);
    }

    /// <summary>
    /// The model_id attribute.
    /// </summary>
    public TerraformProperty<string>? ModelId
    {
        get => GetProperty<TerraformProperty<string>>("model_id");
        set => WithProperty("model_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The template_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TemplateType is required")]
    public required TerraformProperty<string> TemplateType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("template_type");
        set => WithProperty("template_type", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("created_at");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("updated_at");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The customer_encryption_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerEncryptionKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("customer_encryption_key_arn");
        set => this.WithProperty("customer_encryption_key_arn", value);
    }

    /// <summary>
    /// The default_variant attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultVariant
    {
        get => GetProperty<TerraformProperty<string>>("default_variant");
        set => this.WithProperty("default_variant", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for variant.
    /// Nesting mode: list
    /// </summary>
    public List<AwsBedrockagentPromptVariantBlock>? Variant
    {
        get => GetProperty<List<AwsBedrockagentPromptVariantBlock>>("variant");
        set => this.WithProperty("variant", value);
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
