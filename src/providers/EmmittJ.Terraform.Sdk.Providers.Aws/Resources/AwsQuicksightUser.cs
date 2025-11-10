using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_quicksight_user resource.
/// </summary>
public class AwsQuicksightUser : TerraformResource
{
    public AwsQuicksightUser(string name) : base("aws_quicksight_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("user_invitation_url");
        SetOutput("aws_account_id");
        SetOutput("email");
        SetOutput("iam_arn");
        SetOutput("id");
        SetOutput("identity_type");
        SetOutput("namespace");
        SetOutput("region");
        SetOutput("session_name");
        SetOutput("user_name");
        SetOutput("user_role");
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
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformProperty<string> Email
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email");
        set => SetProperty("email", value);
    }

    /// <summary>
    /// The iam_arn attribute.
    /// </summary>
    public TerraformProperty<string> IamArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iam_arn");
        set => SetProperty("iam_arn", value);
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
    /// The identity_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityType is required")]
    public required TerraformProperty<string> IdentityType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_type");
        set => SetProperty("identity_type", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformProperty<string> Namespace
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace");
        set => SetProperty("namespace", value);
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
    /// The session_name attribute.
    /// </summary>
    public TerraformProperty<string> SessionName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("session_name");
        set => SetProperty("session_name", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformProperty<string> UserName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_name");
        set => SetProperty("user_name", value);
    }

    /// <summary>
    /// The user_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserRole is required")]
    public required TerraformProperty<string> UserRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_role");
        set => SetProperty("user_role", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The user_invitation_url attribute.
    /// </summary>
    public TerraformExpression UserInvitationUrl => this["user_invitation_url"];

}
