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
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "additional_language_codes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The gender attribute.
    /// </summary>
    public TerraformValue<string> Gender
    {
        get => new TerraformReference<string>(this, "gender");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    public TerraformValue<string> LanguageCode
    {
        get => new TerraformReference<string>(this, "language_code");
    }

    /// <summary>
    /// The language_name attribute.
    /// </summary>
    public TerraformValue<string> LanguageName
    {
        get => new TerraformReference<string>(this, "language_name");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The supported_engines attribute.
    /// </summary>
    public TerraformList<string> SupportedEngines
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "supported_engines").ResolveNodes(ctx));
    }

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
        get => new TerraformReference<string>(this, "engine");
        set => SetArgument("engine", value);
    }

    /// <summary>
    /// The include_additional_language_codes attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeAdditionalLanguageCodes
    {
        get => new TerraformReference<bool>(this, "include_additional_language_codes");
        set => SetArgument("include_additional_language_codes", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    public TerraformValue<string>? LanguageCode
    {
        get => new TerraformReference<string>(this, "language_code");
        set => SetArgument("language_code", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// Voices block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPollyVoicesDataSourceVoicesBlock>? Voices
    {
        get => GetArgument<TerraformList<AwsPollyVoicesDataSourceVoicesBlock>>("voices");
        set => SetArgument("voices", value);
    }

}
