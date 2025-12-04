using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for voices in AwsPollyVoicesDataSource.
/// Nesting mode: list
/// </summary>
public class AwsPollyVoicesDataSourceVoicesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "voices";

    /// <summary>
    /// The additional_language_codes attribute.
    /// </summary>
    public TerraformList<string> AdditionalLanguageCodes
        => AsReference("additional_language_codes");

    /// <summary>
    /// The gender attribute.
    /// </summary>
    public TerraformValue<string> Gender
        => AsReference("gender");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    public TerraformValue<string> LanguageCode
        => AsReference("language_code");

    /// <summary>
    /// The language_name attribute.
    /// </summary>
    public TerraformValue<string> LanguageName
        => AsReference("language_name");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The supported_engines attribute.
    /// </summary>
    public TerraformList<string> SupportedEngines
        => AsReference("supported_engines");

}


/// <summary>
/// Represents a aws_polly_voices Terraform data source.
/// Retrieves information about a aws_polly_voices.
/// </summary>
public partial class AwsPollyVoicesDataSource(string name) : TerraformDataSource("aws_polly_voices", name)
{
    /// <summary>
    /// The engine attribute.
    /// </summary>
    public TerraformValue<string>? Engine
    {
        get => GetArgument<TerraformValue<string>>("engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The include_additional_language_codes attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeAdditionalLanguageCodes
    {
        get => GetArgument<TerraformValue<bool>>("include_additional_language_codes");
        set => SetArgument("include_additional_language_codes", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    public TerraformValue<string>? LanguageCode
    {
        get => GetArgument<TerraformValue<string>>("language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// Voices block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPollyVoicesDataSourceVoicesBlock>? Voices
    {
        get => GetArgument<TerraformList<AwsPollyVoicesDataSourceVoicesBlock>>("voices");
        set => SetArgument("voices", value);
    }

}
