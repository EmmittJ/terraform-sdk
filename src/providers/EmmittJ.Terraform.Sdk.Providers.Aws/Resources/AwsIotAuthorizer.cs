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
        SetOutput("arn");
        SetOutput("authorizer_function_arn");
        SetOutput("enable_caching_for_http");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("signing_disabled");
        SetOutput("status");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("token_key_name");
        SetOutput("token_signing_public_keys");
    }

    /// <summary>
    /// The authorizer_function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerFunctionArn is required")]
    public required TerraformProperty<string> AuthorizerFunctionArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authorizer_function_arn");
        set => SetProperty("authorizer_function_arn", value);
    }

    /// <summary>
    /// The enable_caching_for_http attribute.
    /// </summary>
    public TerraformProperty<bool> EnableCachingForHttp
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_caching_for_http");
        set => SetProperty("enable_caching_for_http", value);
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
    /// The signing_disabled attribute.
    /// </summary>
    public TerraformProperty<bool> SigningDisabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("signing_disabled");
        set => SetProperty("signing_disabled", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
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
    /// The token_key_name attribute.
    /// </summary>
    public TerraformProperty<string> TokenKeyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("token_key_name");
        set => SetProperty("token_key_name", value);
    }

    /// <summary>
    /// The token_signing_public_keys attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TokenSigningPublicKeys
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("token_signing_public_keys");
        set => SetProperty("token_signing_public_keys", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
