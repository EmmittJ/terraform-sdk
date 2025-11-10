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
        set => SetProperty("default_key", value);
    }

    /// <summary>
    /// The key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyArn is required")]
    public required TerraformProperty<string> KeyArn
    {
        set => SetProperty("key_arn", value);
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
        SetOutput("aws_account_id");
        SetOutput("region");
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformProperty<string> AwsAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aws_account_id");
        set => SetProperty("aws_account_id", value);
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
    /// Block for key_registration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsQuicksightKeyRegistrationKeyRegistrationBlock>? KeyRegistration
    {
        set => SetProperty("key_registration", value);
    }

}
