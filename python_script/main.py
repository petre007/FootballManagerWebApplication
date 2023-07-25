import requests
import random
import time


def goals_bot():
    value = random.randint(0, 10)
    json_req_body = {"goals": str(int(value))}
    url = "http://localhost:5237/goalratio"
    r = requests.put(url,
                     json=json_req_body)
    if r.status_code == 200:
        print("Put request successfully done for goals_bot")
        print("Value added: " + str(int(value)))
    else:
        print("Something went wrong with the PUT request")
        print("Status Code: " + str(r.status_code) +
              "\nContent: " + str(r.content))


def fans_bot():
    value = random.randint(30, 80)
    json_req_body = {"fansNumber": str(int(value))}
    url = "http://localhost:5237/fans"
    r = requests.put(url,
                     json=json_req_body)
    if r.status_code == 200:
        print("Put request successfully done for fans_bot")
        print("Value added: " + str(int(value)))
    else:
        print("Something went wrong with the PUT request")
        print("Status Code: " + str(r.status_code) +
              "\nContent: " + str(r.content))


def budget_bot():
    value = random.randint(0, 10)
    json_req_body = {"money": str(int(value))}
    url = "http://localhost:5237/budget"
    r = requests.put(url,
                     json=json_req_body)
    if r.status_code == 200:
        print("Put request successfully done for budget_bot")
        print("Value added: " + str(int(value)))
    else:
        print("Something went wrong with the PUT request")
        print("Status Code: " + str(r.status_code) +
              "\nContent: " + str(r.content))


def team_value_bot():
    mean_value = 500
    value = mean_value + random.uniform(-1, 1) * 200
    json_req_body = {"value": str(int(value))}
    url = "http://localhost:5237/teamvalue"
    r = requests.put(url,
                     json=json_req_body)
    if r.status_code == 200:
        print("Put request successfully done team_value_bot")
        print("Value added: " + str(int(value)))
    else:
        print("Something went wrong with the PUT request")
        print("Status Code: " + str(r.status_code) +
              "\nContent: " + str(r.content))


def main():
    while True:
        team_value_bot()
        budget_bot()
        fans_bot()
        goals_bot()
        time.sleep(10)
        print("\n")


if __name__ == '__main__':
    main()
