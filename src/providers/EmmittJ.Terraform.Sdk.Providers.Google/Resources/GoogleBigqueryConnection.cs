using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for aws in GoogleBigqueryConnection.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionAwsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws";

    /// <summary>
    /// AccessRole block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessRole is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessRole block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessRole block(s) allowed")]
    public required TerraformList<GoogleBigqueryConnectionAwsBlockAccessRoleBlock> AccessRole
    {
        get => GetRequiredArgument<TerraformList<GoogleBigqueryConnectionAwsBlockAccessRoleBlock>>("access_role");
        set => SetArgument("access_role", value);
    }

}

/// <summary>
/// Block type for access_role in GoogleBigqueryConnectionAwsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionAwsBlockAccessRoleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_role";

    /// <summary>
    /// The user’s AWS IAM Role that trusts the Google-owned AWS IAM user Connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleId is required")]
    public required TerraformValue<string> IamRoleId
    {
        get => GetRequiredArgument<TerraformValue<string>>("iam_role_id");
        set => SetArgument("iam_role_id", value);
    }

    /// <summary>
    /// A unique Google-owned and Google-generated identity for the Connection. This identity will be used to access the user&#39;s AWS IAM Role.
    /// </summary>
    public TerraformValue<string> Identity
        => CreateReference("identity");

}


/// <summary>
/// Block type for azure in GoogleBigqueryConnection.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionAzureBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure";

    /// <summary>
    /// The name of the Azure Active Directory Application.
    /// </summary>
    public TerraformValue<string> Application
        => CreateReference("application");

    /// <summary>
    /// The client id of the Azure Active Directory Application.
    /// </summary>
    public TerraformValue<string> ClientId
        => CreateReference("client_id");

    /// <summary>
    /// The id of customer&#39;s directory that host the data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerTenantId is required")]
    public required TerraformValue<string> CustomerTenantId
    {
        get => GetRequiredArgument<TerraformValue<string>>("customer_tenant_id");
        set => SetArgument("customer_tenant_id", value);
    }

    /// <summary>
    /// The Azure Application (client) ID where the federated credentials will be hosted.
    /// </summary>
    public TerraformValue<string>? FederatedApplicationClientId
    {
        get => GetArgument<TerraformValue<string>>("federated_application_client_id");
        set => SetArgument("federated_application_client_id", value);
    }

    /// <summary>
    /// A unique Google-owned and Google-generated identity for the Connection. This identity will be used to access the user&#39;s Azure Active Directory Application.
    /// </summary>
    public TerraformValue<string> Identity
        => CreateReference("identity");

    /// <summary>
    /// The object id of the Azure Active Directory Application.
    /// </summary>
    public TerraformValue<string> ObjectId
        => CreateReference("object_id");

    /// <summary>
    /// The URL user will be redirected to after granting consent during connection setup.
    /// </summary>
    public TerraformValue<string> RedirectUri
        => CreateReference("redirect_uri");

}


/// <summary>
/// Block type for cloud_resource in GoogleBigqueryConnection.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionCloudResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_resource";

    /// <summary>
    /// The account ID of the service created for the purpose of this connection.
    /// </summary>
    public TerraformValue<string> ServiceAccountId
        => CreateReference("service_account_id");

}


/// <summary>
/// Block type for cloud_spanner in GoogleBigqueryConnection.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionCloudSpannerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_spanner";

    /// <summary>
    /// Cloud Spanner database in the form &#39;project/instance/database&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetRequiredArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// Cloud Spanner database role for fine-grained access control. The Cloud Spanner admin should have provisioned the database role with appropriate permissions, such as &#39;SELECT&#39; and &#39;INSERT&#39;. Other users should only use roles provided by their Cloud Spanner admins. The database role name must start with a letter, and can only contain letters, numbers, and underscores. For more details, see https://cloud.google.com/spanner/docs/fgac-about.
    /// </summary>
    public TerraformValue<string>? DatabaseRole
    {
        get => GetArgument<TerraformValue<string>>("database_role");
        set => SetArgument("database_role", value);
    }

    /// <summary>
    /// Allows setting max parallelism per query when executing on Spanner independent compute resources. If unspecified, default values of parallelism are chosen that are dependent on the Cloud Spanner instance configuration. &#39;useParallelism&#39; and &#39;useDataBoost&#39; must be set when setting max parallelism.
    /// </summary>
    public TerraformValue<double>? MaxParallelism
    {
        get => GetArgument<TerraformValue<double>>("max_parallelism");
        set => SetArgument("max_parallelism", value);
    }

    /// <summary>
    /// If set, the request will be executed via Spanner independent compute resources. &#39;use_parallelism&#39; must be set when using data boost.
    /// </summary>
    public TerraformValue<bool>? UseDataBoost
    {
        get => GetArgument<TerraformValue<bool>>("use_data_boost");
        set => SetArgument("use_data_boost", value);
    }

    /// <summary>
    /// If parallelism should be used when reading from Cloud Spanner.
    /// </summary>
    public TerraformValue<bool>? UseParallelism
    {
        get => GetArgument<TerraformValue<bool>>("use_parallelism");
        set => SetArgument("use_parallelism", value);
    }

    /// <summary>
    /// If the serverless analytics service should be used to read data from Cloud Spanner. &#39;useParallelism&#39; must be set when using serverless analytics.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool>? UseServerlessAnalytics
    {
        get => GetArgument<TerraformValue<bool>>("use_serverless_analytics");
        set => SetArgument("use_serverless_analytics", value);
    }

}


/// <summary>
/// Block type for cloud_sql in GoogleBigqueryConnection.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionCloudSqlBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_sql";

    /// <summary>
    /// Database name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetRequiredArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// Cloud SQL instance ID in the form project:location:instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformValue<string> InstanceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_id");
        set => SetArgument("instance_id", value);
    }

    /// <summary>
    /// When the connection is used in the context of an operation in BigQuery, this service account will serve as the identity being used for connecting to the CloudSQL instance specified in this connection.
    /// </summary>
    public TerraformValue<string> ServiceAccountId
        => CreateReference("service_account_id");

    /// <summary>
    /// Type of the Cloud SQL database. Possible values: [&amp;quot;DATABASE_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;POSTGRES&amp;quot;, &amp;quot;MYSQL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Credential block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Credential is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Credential block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Credential block(s) allowed")]
    public required TerraformList<GoogleBigqueryConnectionCloudSqlBlockCredentialBlock> Credential
    {
        get => GetRequiredArgument<TerraformList<GoogleBigqueryConnectionCloudSqlBlockCredentialBlock>>("credential");
        set => SetArgument("credential", value);
    }

}

/// <summary>
/// Block type for credential in GoogleBigqueryConnectionCloudSqlBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionCloudSqlBlockCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "credential";

    /// <summary>
    /// Password for database.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// Username for database.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for spark in GoogleBigqueryConnection.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionSparkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark";

    /// <summary>
    /// The account ID of the service created for the purpose of this connection.
    /// </summary>
    public TerraformValue<string> ServiceAccountId
        => CreateReference("service_account_id");

    /// <summary>
    /// MetastoreServiceConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetastoreServiceConfig block(s) allowed")]
    public TerraformList<GoogleBigqueryConnectionSparkBlockMetastoreServiceConfigBlock>? MetastoreServiceConfig
    {
        get => GetArgument<TerraformList<GoogleBigqueryConnectionSparkBlockMetastoreServiceConfigBlock>>("metastore_service_config");
        set => SetArgument("metastore_service_config", value);
    }

    /// <summary>
    /// SparkHistoryServerConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SparkHistoryServerConfig block(s) allowed")]
    public TerraformList<GoogleBigqueryConnectionSparkBlockSparkHistoryServerConfigBlock>? SparkHistoryServerConfig
    {
        get => GetArgument<TerraformList<GoogleBigqueryConnectionSparkBlockSparkHistoryServerConfigBlock>>("spark_history_server_config");
        set => SetArgument("spark_history_server_config", value);
    }

}

/// <summary>
/// Block type for metastore_service_config in GoogleBigqueryConnectionSparkBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionSparkBlockMetastoreServiceConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metastore_service_config";

    /// <summary>
    /// Resource name of an existing Dataproc Metastore service in the form of projects/[projectId]/locations/[region]/services/[serviceId].
    /// </summary>
    public TerraformValue<string>? MetastoreService
    {
        get => GetArgument<TerraformValue<string>>("metastore_service");
        set => SetArgument("metastore_service", value);
    }

}

/// <summary>
/// Block type for spark_history_server_config in GoogleBigqueryConnectionSparkBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionSparkBlockSparkHistoryServerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "spark_history_server_config";

    /// <summary>
    /// Resource name of an existing Dataproc Cluster to act as a Spark History Server for the connection if the form of projects/[projectId]/regions/[region]/clusters/[cluster_name].
    /// </summary>
    public TerraformValue<string>? DataprocCluster
    {
        get => GetArgument<TerraformValue<string>>("dataproc_cluster");
        set => SetArgument("dataproc_cluster", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBigqueryConnection.
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_bigquery_connection Terraform resource.
/// Manages a google_bigquery_connection resource.
/// </summary>
public partial class GoogleBigqueryConnection(string name) : TerraformResource("google_bigquery_connection", name)
{
    /// <summary>
    /// Optional connection id that should be assigned to the created connection.
    /// </summary>
    public TerraformValue<string> ConnectionId
    {
        get => GetArgument<TerraformValue<string>>("connection_id") ?? CreateReference("connection_id");
        set => SetArgument("connection_id", value);
    }

    /// <summary>
    /// A descriptive description for the connection
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// A descriptive name for the connection
    /// </summary>
    public TerraformValue<string>? FriendlyName
    {
        get => GetArgument<TerraformValue<string>>("friendly_name");
        set => SetArgument("friendly_name", value);
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
    /// Optional. The Cloud KMS key that is used for encryption.
    /// 
    /// Example: projects/[kms_project_id]/locations/[region]/keyRings/[key_region]/cryptoKeys/[key]
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => GetArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// The geographic location where the connection should reside.
    /// Cloud SQL instance must be in the same location as the connection
    /// with following exceptions: Cloud SQL us-central1 maps to BigQuery US, Cloud SQL europe-west1 maps to BigQuery EU.
    /// Examples: US, EU, asia-northeast1, us-central1, europe-west1.
    /// Spanner Connections same as spanner region
    /// AWS allowed regions are aws-us-east-1
    /// Azure allowed regions are azure-eastus2
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// True if the connection has credential assigned.
    /// </summary>
    public TerraformValue<bool> HasCredential
        => CreateReference("has_credential");

    /// <summary>
    /// The resource name of the connection in the form of:
    /// &amp;quot;projects/{project_id}/locations/{location_id}/connections/{connectionId}&amp;quot;
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Aws block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Aws block(s) allowed")]
    public TerraformList<GoogleBigqueryConnectionAwsBlock>? Aws
    {
        get => GetArgument<TerraformList<GoogleBigqueryConnectionAwsBlock>>("aws");
        set => SetArgument("aws", value);
    }

    /// <summary>
    /// Azure block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Azure block(s) allowed")]
    public TerraformList<GoogleBigqueryConnectionAzureBlock>? Azure
    {
        get => GetArgument<TerraformList<GoogleBigqueryConnectionAzureBlock>>("azure");
        set => SetArgument("azure", value);
    }

    /// <summary>
    /// CloudResource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudResource block(s) allowed")]
    public TerraformList<GoogleBigqueryConnectionCloudResourceBlock>? CloudResource
    {
        get => GetArgument<TerraformList<GoogleBigqueryConnectionCloudResourceBlock>>("cloud_resource");
        set => SetArgument("cloud_resource", value);
    }

    /// <summary>
    /// CloudSpanner block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudSpanner block(s) allowed")]
    public TerraformList<GoogleBigqueryConnectionCloudSpannerBlock>? CloudSpanner
    {
        get => GetArgument<TerraformList<GoogleBigqueryConnectionCloudSpannerBlock>>("cloud_spanner");
        set => SetArgument("cloud_spanner", value);
    }

    /// <summary>
    /// CloudSql block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudSql block(s) allowed")]
    public TerraformList<GoogleBigqueryConnectionCloudSqlBlock>? CloudSql
    {
        get => GetArgument<TerraformList<GoogleBigqueryConnectionCloudSqlBlock>>("cloud_sql");
        set => SetArgument("cloud_sql", value);
    }

    /// <summary>
    /// Spark block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spark block(s) allowed")]
    public TerraformList<GoogleBigqueryConnectionSparkBlock>? Spark
    {
        get => GetArgument<TerraformList<GoogleBigqueryConnectionSparkBlock>>("spark");
        set => SetArgument("spark", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigqueryConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigqueryConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
