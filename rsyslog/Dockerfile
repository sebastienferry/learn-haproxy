# Use ubuntu as base image
FROM ubuntu
# Install rsyslog
RUN apt update
RUN apt install rsyslog -y
# Feed rsyslog with our ad-hoc config file
ADD haproxy.conf /etc/rsyslog.d/haproxy.conf
# Declare a volume to be mount to see the logs from the host OS
VOLUME /var/log/haproxy
# Expose the port 514/udp to receive logs
EXPOSE 514/udp
# Start rsyslog
ENTRYPOINT ["rsyslogd", "-n"]