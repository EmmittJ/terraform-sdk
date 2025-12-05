using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_secretsmanager_random_password Terraform data source.
/// Retrieves information about a aws_secretsmanager_random_password.
/// </summary>
public partial class AwsSecretsmanagerRandomPasswordDataSource(string name) : TerraformDataSource("aws_secretsmanager_random_password", name)
{
    /// <summary>
    /// The exclude_characters attribute.
    /// </summary>
    public TerraformValue<string>? ExcludeCharacters
    {
        get => GetArgument<TerraformValue<string>>("exclude_characters");
        set => SetArgument("exclude_characters", value);
    }

    /// <summary>
    /// The exclude_lowercase attribute.
    /// </summary>
    public TerraformValue<bool>? ExcludeLowercase
    {
        get => GetArgument<TerraformValue<bool>>("exclude_lowercase");
        set => SetArgument("exclude_lowercase", value);
    }

    /// <summary>
    /// The exclude_numbers attribute.
    /// </summary>
    public TerraformValue<bool>? ExcludeNumbers
    {
        get => GetArgument<TerraformValue<bool>>("exclude_numbers");
        set => SetArgument("exclude_numbers", value);
    }

    /// <summary>
    /// The exclude_punctuation attribute.
    /// </summary>
    public TerraformValue<bool>? ExcludePunctuation
    {
        get => GetArgument<TerraformValue<bool>>("exclude_punctuation");
        set => SetArgument("exclude_punctuation", value);
    }

    /// <summary>
    /// The exclude_uppercase attribute.
    /// </summary>
    public TerraformValue<bool>? ExcludeUppercase
    {
        get => GetArgument<TerraformValue<bool>>("exclude_uppercase");
        set => SetArgument("exclude_uppercase", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The include_space attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeSpace
    {
        get => GetArgument<TerraformValue<bool>>("include_space");
        set => SetArgument("include_space", value);
    }

    /// <summary>
    /// The password_length attribute.
    /// </summary>
    public TerraformValue<double>? PasswordLength
    {
        get => GetArgument<TerraformValue<double>>("password_length");
        set => SetArgument("password_length", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The require_each_included_type attribute.
    /// </summary>
    public TerraformValue<bool>? RequireEachIncludedType
    {
        get => GetArgument<TerraformValue<bool>>("require_each_included_type");
        set => SetArgument("require_each_included_type", value);
    }

    /// <summary>
    /// The random_password attribute.
    /// </summary>
    public TerraformValue<string> RandomPassword
        => CreateReference("random_password");

}
