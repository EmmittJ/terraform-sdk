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
        this.DeclareOutput("arn");
        this.DeclareOutput("user_invitation_url");
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public string? AwsAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_account_id")?.Value;
        set => this.WithProperty("aws_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public string? Email
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email")?.Value;
        set => this.WithProperty("email", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The iam_arn attribute.
    /// </summary>
    public string? IamArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_arn")?.Value;
        set => this.WithProperty("iam_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    public string? IdentityType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_type")?.Value;
        set => this.WithProperty("identity_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public string? Namespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace")?.Value;
        set => this.WithProperty("namespace", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The session_name attribute.
    /// </summary>
    public string? SessionName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("session_name")?.Value;
        set => this.WithProperty("session_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public string? UserName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_name")?.Value;
        set => this.WithProperty("user_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_role attribute.
    /// </summary>
    public string? UserRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_role")?.Value;
        set => this.WithProperty("user_role", value == null ? null : new TerraformLiteralProperty<string>(value));
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
