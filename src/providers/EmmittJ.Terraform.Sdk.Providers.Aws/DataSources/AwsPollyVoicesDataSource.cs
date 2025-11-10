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
        get => GetProperty<List<TerraformProperty<string>>>("additional_language_codes");
        set => WithProperty("additional_language_codes", value);
    }

    /// <summary>
    /// The gender attribute.
    /// </summary>
    public TerraformProperty<string>? Gender
    {
        get => GetProperty<TerraformProperty<string>>("gender");
        set => WithProperty("gender", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    public TerraformProperty<string>? LanguageCode
    {
        get => GetProperty<TerraformProperty<string>>("language_code");
        set => WithProperty("language_code", value);
    }

    /// <summary>
    /// The language_name attribute.
    /// </summary>
    public TerraformProperty<string>? LanguageName
    {
        get => GetProperty<TerraformProperty<string>>("language_name");
        set => WithProperty("language_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The supported_engines attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SupportedEngines
    {
        get => GetProperty<List<TerraformProperty<string>>>("supported_engines");
        set => WithProperty("supported_engines", value);
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
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformProperty<string>? Engine
    {
        get => GetProperty<TerraformProperty<string>>("engine");
        set => this.WithProperty("engine", value);
    }

    /// <summary>
    /// The include_additional_language_codes attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeAdditionalLanguageCodes
    {
        get => GetProperty<TerraformProperty<bool>>("include_additional_language_codes");
        set => this.WithProperty("include_additional_language_codes", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    public TerraformProperty<string>? LanguageCode
    {
        get => GetProperty<TerraformProperty<string>>("language_code");
        set => this.WithProperty("language_code", value);
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
    /// Block for voices.
    /// Nesting mode: list
    /// </summary>
    public List<AwsPollyVoicesDataSourceVoicesBlock>? Voices
    {
        get => GetProperty<List<AwsPollyVoicesDataSourceVoicesBlock>>("voices");
        set => this.WithProperty("voices", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
