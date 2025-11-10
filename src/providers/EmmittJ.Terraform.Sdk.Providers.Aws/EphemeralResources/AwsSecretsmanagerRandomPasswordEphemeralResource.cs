using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_secretsmanager_random_password ephemeral resource (temporary credentials/tokens).
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public class AwsSecretsmanagerRandomPasswordEphemeralResource : TerraformEphemeralResource
{
    public AwsSecretsmanagerRandomPasswordEphemeralResource(string name) : base("aws_secretsmanager_random_password", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("random_password");
        SetOutput("exclude_characters");
        SetOutput("exclude_lowercase");
        SetOutput("exclude_numbers");
        SetOutput("exclude_punctuation");
        SetOutput("exclude_uppercase");
        SetOutput("include_space");
        SetOutput("password_length");
        SetOutput("region");
        SetOutput("require_each_included_type");
    }

    /// <summary>
    /// The exclude_characters attribute.
    /// </summary>
    public TerraformProperty<string> ExcludeCharacters
    {
        get => GetRequiredOutput<TerraformProperty<string>>("exclude_characters");
        set => SetProperty("exclude_characters", value);
    }

    /// <summary>
    /// The exclude_lowercase attribute.
    /// </summary>
    public TerraformProperty<bool> ExcludeLowercase
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("exclude_lowercase");
        set => SetProperty("exclude_lowercase", value);
    }

    /// <summary>
    /// The exclude_numbers attribute.
    /// </summary>
    public TerraformProperty<bool> ExcludeNumbers
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("exclude_numbers");
        set => SetProperty("exclude_numbers", value);
    }

    /// <summary>
    /// The exclude_punctuation attribute.
    /// </summary>
    public TerraformProperty<bool> ExcludePunctuation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("exclude_punctuation");
        set => SetProperty("exclude_punctuation", value);
    }

    /// <summary>
    /// The exclude_uppercase attribute.
    /// </summary>
    public TerraformProperty<bool> ExcludeUppercase
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("exclude_uppercase");
        set => SetProperty("exclude_uppercase", value);
    }

    /// <summary>
    /// The include_space attribute.
    /// </summary>
    public TerraformProperty<bool> IncludeSpace
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("include_space");
        set => SetProperty("include_space", value);
    }

    /// <summary>
    /// The password_length attribute.
    /// </summary>
    public TerraformProperty<double> PasswordLength
    {
        get => GetRequiredOutput<TerraformProperty<double>>("password_length");
        set => SetProperty("password_length", value);
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
    /// The require_each_included_type attribute.
    /// </summary>
    public TerraformProperty<bool> RequireEachIncludedType
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("require_each_included_type");
        set => SetProperty("require_each_included_type", value);
    }

    /// <summary>
    /// The random_password attribute.
    /// </summary>
    public TerraformExpression RandomPassword => this["random_password"];

}
