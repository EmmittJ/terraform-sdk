using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for key_registration in .
/// Nesting mode: set
/// </summary>
public class AwsQuicksightKeyRegistrationKeyRegistrationBlock : TerraformBlock
{
    /// <summary>
    /// The default_key attribute.
    /// </summary>
    public TerraformProperty<bool>? DefaultKey
    {
        get => GetProperty<TerraformProperty<bool>>("default_key");
        set => WithProperty("default_key", value);
    }

    /// <summary>
    /// The key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyArn is required")]
    public required TerraformProperty<string> KeyArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key_arn");
        set => WithProperty("key_arn", value);
    }

}

/// <summary>
/// Manages a aws_quicksight_key_registration resource.
/// </summary>
public class AwsQuicksightKeyRegistration : TerraformResource
{
    public AwsQuicksightKeyRegistration(string name) : base("aws_quicksight_key_registration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AwsAccountId
    {
        get => GetProperty<TerraformProperty<string>>("aws_account_id");
        set => this.WithProperty("aws_account_id", value);
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
    /// Block for key_registration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsQuicksightKeyRegistrationKeyRegistrationBlock>? KeyRegistration
    {
        get => GetProperty<HashSet<AwsQuicksightKeyRegistrationKeyRegistrationBlock>>("key_registration");
        set => this.WithProperty("key_registration", value);
    }

}
