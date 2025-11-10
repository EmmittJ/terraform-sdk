using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for voices in .
/// Nesting mode: list
/// </summary>
public class AwsPollyVoicesDataSourceVoicesBlock : TerraformBlock
{
    /// <summary>
    /// The additional_language_codes attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AdditionalLanguageCodes
    {
        set => SetProperty("additional_language_codes", value);
    }

    /// <summary>
    /// The gender attribute.
    /// </summary>
    public TerraformProperty<string>? Gender
    {
        set => SetProperty("gender", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    public TerraformProperty<string>? LanguageCode
    {
        set => SetProperty("language_code", value);
    }

    /// <summary>
    /// The language_name attribute.
    /// </summary>
    public TerraformProperty<string>? LanguageName
    {
        set => SetProperty("language_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The supported_engines attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SupportedEngines
    {
        set => SetProperty("supported_engines", value);
    }

}

/// <summary>
/// Retrieves information about a aws_polly_voices.
/// </summary>
public class AwsPollyVoicesDataSource : TerraformDataSource
{
    public AwsPollyVoicesDataSource(string name) : base("aws_polly_voices", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("engine");
        SetOutput("include_additional_language_codes");
        SetOutput("language_code");
        SetOutput("region");
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string> Engine
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine");
        set => SetProperty("engine", value);
    }

    /// <summary>
    /// The include_additional_language_codes attribute.
    /// </summary>
    public TerraformProperty<bool> IncludeAdditionalLanguageCodes
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("include_additional_language_codes");
        set => SetProperty("include_additional_language_codes", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    public TerraformProperty<string> LanguageCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("language_code");
        set => SetProperty("language_code", value);
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
    /// Block for voices.
    /// Nesting mode: list
    /// </summary>
    public List<AwsPollyVoicesDataSourceVoicesBlock>? Voices
    {
        set => SetProperty("voices", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
