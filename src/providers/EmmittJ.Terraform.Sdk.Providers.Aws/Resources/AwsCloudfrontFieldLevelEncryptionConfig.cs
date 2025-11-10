using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for content_type_profile_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigBlock : TerraformBlock
{
    /// <summary>
    /// The forward_when_content_type_is_unknown attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardWhenContentTypeIsUnknown is required")]
    public required TerraformProperty<bool> ForwardWhenContentTypeIsUnknown
    {
        set => SetProperty("forward_when_content_type_is_unknown", value);
    }

}

/// <summary>
/// Block type for query_arg_profile_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigBlock : TerraformBlock
{
    /// <summary>
    /// The forward_when_query_arg_profile_is_unknown attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForwardWhenQueryArgProfileIsUnknown is required")]
    public required TerraformProperty<bool> ForwardWhenQueryArgProfileIsUnknown
    {
        set => SetProperty("forward_when_query_arg_profile_is_unknown", value);
    }

}

/// <summary>
/// Manages a aws_cloudfront_field_level_encryption_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudfrontFieldLevelEncryptionConfig : TerraformResource
{
    public AwsCloudfrontFieldLevelEncryptionConfig(string name) : base("aws_cloudfront_field_level_encryption_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("caller_reference");
        SetOutput("etag");
        SetOutput("comment");
        SetOutput("id");
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformProperty<string> Comment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("comment");
        set => SetProperty("comment", value);
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
    /// Block for content_type_profile_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContentTypeProfileConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ContentTypeProfileConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ContentTypeProfileConfig block(s) allowed")]
    public List<AwsCloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigBlock>? ContentTypeProfileConfig
    {
        set => SetProperty("content_type_profile_config", value);
    }

    /// <summary>
    /// Block for query_arg_profile_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryArgProfileConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 QueryArgProfileConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QueryArgProfileConfig block(s) allowed")]
    public List<AwsCloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigBlock>? QueryArgProfileConfig
    {
        set => SetProperty("query_arg_profile_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The caller_reference attribute.
    /// </summary>
    public TerraformExpression CallerReference => this["caller_reference"];

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
