using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_authorizer resource.
/// </summary>
public class AwsIotAuthorizer : TerraformResource
{
    public AwsIotAuthorizer(string name) : base("aws_iot_authorizer", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The authorizer_function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerFunctionArn is required")]
    public required TerraformProperty<string> AuthorizerFunctionArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("authorizer_function_arn");
        set => this.WithProperty("authorizer_function_arn", value);
    }

    /// <summary>
    /// The enable_caching_for_http attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableCachingForHttp
    {
        get => GetProperty<TerraformProperty<bool>>("enable_caching_for_http");
        set => this.WithProperty("enable_caching_for_http", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The signing_disabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SigningDisabled
    {
        get => GetProperty<TerraformProperty<bool>>("signing_disabled");
        set => this.WithProperty("signing_disabled", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The token_key_name attribute.
    /// </summary>
    public TerraformProperty<string>? TokenKeyName
    {
        get => GetProperty<TerraformProperty<string>>("token_key_name");
        set => this.WithProperty("token_key_name", value);
    }

    /// <summary>
    /// The token_signing_public_keys attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TokenSigningPublicKeys
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("token_signing_public_keys");
        set => this.WithProperty("token_signing_public_keys", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
