using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_quicksight_account_subscription resource.
/// </summary>
public class AwsQuicksightAccountSubscription : TerraformResource
{
    public AwsQuicksightAccountSubscription(string name) : base("aws_quicksight_account_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("account_subscription_status");
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    public string? AccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_name")?.Value;
        set => this.WithProperty("account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The active_directory_name attribute.
    /// </summary>
    public string? ActiveDirectoryName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("active_directory_name")?.Value;
        set => this.WithProperty("active_directory_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The admin_group attribute.
    /// </summary>
    public List<string>? AdminGroup
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("admin_group")?.Value;
        set => this.WithProperty("admin_group", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The admin_pro_group attribute.
    /// </summary>
    public List<string>? AdminProGroup
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("admin_pro_group")?.Value;
        set => this.WithProperty("admin_pro_group", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The authentication_method attribute.
    /// </summary>
    public string? AuthenticationMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_method")?.Value;
        set => this.WithProperty("authentication_method", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The author_group attribute.
    /// </summary>
    public List<string>? AuthorGroup
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("author_group")?.Value;
        set => this.WithProperty("author_group", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The author_pro_group attribute.
    /// </summary>
    public List<string>? AuthorProGroup
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("author_pro_group")?.Value;
        set => this.WithProperty("author_pro_group", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The contact_number attribute.
    /// </summary>
    public string? ContactNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("contact_number")?.Value;
        set => this.WithProperty("contact_number", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public string? DirectoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("directory_id")?.Value;
        set => this.WithProperty("directory_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The edition attribute.
    /// </summary>
    public string? Edition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("edition")?.Value;
        set => this.WithProperty("edition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public string? EmailAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_address")?.Value;
        set => this.WithProperty("email_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public string? FirstName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("first_name")?.Value;
        set => this.WithProperty("first_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The iam_identity_center_instance_arn attribute.
    /// </summary>
    public string? IamIdentityCenterInstanceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_identity_center_instance_arn")?.Value;
        set => this.WithProperty("iam_identity_center_instance_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The last_name attribute.
    /// </summary>
    public string? LastName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("last_name")?.Value;
        set => this.WithProperty("last_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The notification_email attribute.
    /// </summary>
    public string? NotificationEmail
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_email")?.Value;
        set => this.WithProperty("notification_email", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The reader_group attribute.
    /// </summary>
    public List<string>? ReaderGroup
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("reader_group")?.Value;
        set => this.WithProperty("reader_group", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The reader_pro_group attribute.
    /// </summary>
    public List<string>? ReaderProGroup
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("reader_pro_group")?.Value;
        set => this.WithProperty("reader_pro_group", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The realm attribute.
    /// </summary>
    public string? Realm
    {
        get => GetProperty<TerraformLiteralProperty<string>>("realm")?.Value;
        set => this.WithProperty("realm", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The account_subscription_status attribute.
    /// </summary>
    public TerraformExpression AccountSubscriptionStatus => this["account_subscription_status"];

}
