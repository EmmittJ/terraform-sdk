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
        get => new TerraformReference<string>(this, "exclude_characters");
        set => SetArgument("exclude_characters", value);
    }

    /// <summary>
    /// The exclude_lowercase attribute.
    /// </summary>
    public TerraformValue<bool>? ExcludeLowercase
    {
        get => new TerraformReference<bool>(this, "exclude_lowercase");
        set => SetArgument("exclude_lowercase", value);
    }

    /// <summary>
    /// The exclude_numbers attribute.
    /// </summary>
    public TerraformValue<bool>? ExcludeNumbers
    {
        get => new TerraformReference<bool>(this, "exclude_numbers");
        set => SetArgument("exclude_numbers", value);
    }

    /// <summary>
    /// The exclude_punctuation attribute.
    /// </summary>
    public TerraformValue<bool>? ExcludePunctuation
    {
        get => new TerraformReference<bool>(this, "exclude_punctuation");
        set => SetArgument("exclude_punctuation", value);
    }

    /// <summary>
    /// The exclude_uppercase attribute.
    /// </summary>
    public TerraformValue<bool>? ExcludeUppercase
    {
        get => new TerraformReference<bool>(this, "exclude_uppercase");
        set => SetArgument("exclude_uppercase", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The include_space attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeSpace
    {
        get => new TerraformReference<bool>(this, "include_space");
        set => SetArgument("include_space", value);
    }

    /// <summary>
    /// The password_length attribute.
    /// </summary>
    public TerraformValue<double>? PasswordLength
    {
        get => new TerraformReference<double>(this, "password_length");
        set => SetArgument("password_length", value);
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
    /// The require_each_included_type attribute.
    /// </summary>
    public TerraformValue<bool>? RequireEachIncludedType
    {
        get => new TerraformReference<bool>(this, "require_each_included_type");
        set => SetArgument("require_each_included_type", value);
    }

    /// <summary>
    /// The random_password attribute.
    /// </summary>
    public TerraformValue<string> RandomPassword
    {
        get => new TerraformReference<string>(this, "random_password");
    }

}
